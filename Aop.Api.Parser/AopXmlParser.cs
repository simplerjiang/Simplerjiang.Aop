using Aop.Api.Request;
using Aop.Api.Util;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Aop.Api.Parser
{
	public class AopXmlParser<T> : IAopParser<T> where T : AopResponse
	{
		private static Regex regex = new Regex("<(\\w+?)[ >]", RegexOptions.Compiled);

		private static Dictionary<string, XmlSerializer> parsers = new Dictionary<string, XmlSerializer>();

		public T Parse(string body, string charset)
		{
			XmlSerializer value = null;
			string rootElement = GetRootElement(body);
			if (!parsers.TryGetValue(rootElement, out value) || value == null)
			{
				XmlAttributes xmlAttributes = new XmlAttributes();
				xmlAttributes.XmlRoot = new XmlRootAttribute(rootElement);
				XmlAttributeOverrides xmlAttributeOverrides = new XmlAttributeOverrides();
				xmlAttributeOverrides.Add(typeof(T), xmlAttributes);
				value = new XmlSerializer(typeof(T), xmlAttributeOverrides);
				parsers[rootElement] = value;
			}
			object obj = null;
			Encoding encoding = null;
			encoding = ((!string.IsNullOrEmpty(charset)) ? Encoding.GetEncoding(charset) : Encoding.UTF8);
			using (Stream stream = new MemoryStream(encoding.GetBytes(body)))
			{
				obj = value.Deserialize(stream);
			}
			T val = (T)obj;
			if (val != null)
			{
				val.Body = body;
			}
			return val;
		}

		public SignItem GetSignItem(IAopRequest<T> request, string reponseBody)
		{
			if (string.IsNullOrEmpty(reponseBody))
			{
				return null;
			}
			SignItem signItem = new SignItem();
			string text = signItem.Sign = GetSign(reponseBody);
			string text2 = signItem.SignSourceDate = GetSignSourceData(request, reponseBody);
			return signItem;
		}

		private string GetRootElement(string body)
		{
			Match match = regex.Match(body);
			if (match.Success)
			{
				return match.Groups[1].ToString();
			}
			throw new AopException("Invalid XML response format!");
		}

		private static string GetSign(string body)
		{
			string text = "<sign>";
			string value = "</sign>";
			int num = body.IndexOf(text);
			int num2 = body.IndexOf(value);
			if (num < 0 || num2 < 0)
			{
				return null;
			}
			int num3 = num + text.Length;
			return body.Substring(num3, num2 - num3);
		}

		private static string GetSignSourceData(IAopRequest<T> request, string body)
		{
			string text = request.GetApiName().Replace(".", "_") + "_response";
			string text2 = "error_response";
			int num = body.IndexOf(text);
			int num2 = body.IndexOf(text2);
			string result = null;
			if (num > 0)
			{
				result = ParseSignSourceData(body, text, num);
			}
			else if (num2 > 0)
			{
				result = ParseSignSourceData(body, text2, num2);
			}
			return result;
		}

		private static string ParseSignSourceData(string body, string rootNode, int indexOfRootNode)
		{
			int num = indexOfRootNode + rootNode.Length + 1;
			int num2 = body.IndexOf("<sign");
			if (num2 < 0)
			{
				return null;
			}
			int num3 = num2;
			return body.Substring(num, num3 - num);
		}

		public string EncryptSourceData(IAopRequest<T> request, string body, string encryptType, string encryptKey, string charset)
		{
			EncryptParseItem encryptParseItem = ParseEncryptData(request, body);
			string str = body.Substring(0, encryptParseItem.startIndex);
			string str2 = body.Substring(encryptParseItem.endIndex);
			string str3 = AlipayEncrypt.AesDencrypt(encryptKey, encryptParseItem.encryptContent, charset);
			return str + str3 + str2;
		}

		private static EncryptParseItem ParseEncryptData(IAopRequest<T> request, string body)
		{
			string text = request.GetApiName().Replace(".", "_") + "_response";
			string text2 = "error_response";
			int num = body.IndexOf(text);
			int num2 = body.IndexOf(text2);
			EncryptParseItem result = null;
			if (num > 0)
			{
				result = ParseEncryptItem(body, text, num);
			}
			else if (num2 > 0)
			{
				result = ParseEncryptItem(body, text2, num2);
			}
			return result;
		}

		private static EncryptParseItem ParseEncryptItem(string body, string rootNode, int indexOfRootNode)
		{
			int num = indexOfRootNode + rootNode.Length + 1;
			string text = "<response_encrypted>";
			string text2 = "</response_encrypted>";
			int num2 = body.IndexOf(text2);
			if (num2 < 0)
			{
				EncryptParseItem encryptParseItem = new EncryptParseItem();
				encryptParseItem.encryptContent = null;
				encryptParseItem.startIndex = 0;
				encryptParseItem.endIndex = 0;
				return encryptParseItem;
			}
			int num3 = num + text.Length;
			int length = num2 - num3;
			string encryptContent = body.Substring(num3, length);
			EncryptParseItem encryptParseItem2 = new EncryptParseItem();
			encryptParseItem2.encryptContent = encryptContent;
			encryptParseItem2.startIndex = num;
			encryptParseItem2.endIndex = num2 + text2.Length;
			return encryptParseItem2;
		}
	}
}

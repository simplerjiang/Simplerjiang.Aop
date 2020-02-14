using Jayrock.Json.Conversion;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Aop.Api.Util
{
	public abstract class AopUtils
	{
		public static string AesEncrypt(string encryptKey, string bizContent, string charset)
		{
			return AlipayEncrypt.AesEncrypt(encryptKey, bizContent, charset);
		}

		public static string SignAopRequest(IDictionary<string, string> parameters, string privateKeyPem, string charset, string signType)
		{
			return AlipaySignature.RSASign(parameters, privateKeyPem, charset, signType);
		}

		public static string SignAopRequest(IDictionary<string, string> parameters, string privateKeyPem, string charset, bool keyFromFile, string signType)
		{
			return AlipaySignature.RSASign(parameters, privateKeyPem, charset, keyFromFile, signType);
		}

		public static IDictionary<string, T> CleanupDictionary<T>(IDictionary<string, T> dict)
		{
			IDictionary<string, T> dictionary = new Dictionary<string, T>(dict.Count);
			IEnumerator<KeyValuePair<string, T>> enumerator = dict.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string key = enumerator.Current.Key;
				T value = enumerator.Current.Value;
				if (value != null)
				{
					dictionary.Add(key, value);
				}
			}
			return dictionary;
		}

		public static string GetFileSuffix(byte[] fileData)
		{
			if (fileData == null || fileData.Length < 10)
			{
				return null;
			}
			if (fileData[0] == 71 && fileData[1] == 73 && fileData[2] == 70)
			{
				return "GIF";
			}
			if (fileData[1] == 80 && fileData[2] == 78 && fileData[3] == 71)
			{
				return "PNG";
			}
			if (fileData[6] == 74 && fileData[7] == 70 && fileData[8] == 73 && fileData[9] == 70)
			{
				return "JPG";
			}
			if (fileData[0] == 66 && fileData[1] == 77)
			{
				return "BMP";
			}
			return null;
		}

		public static string GetMimeType(byte[] fileData)
		{
			switch (GetFileSuffix(fileData))
			{
			case "JPG":
				return "image/jpeg";
			case "GIF":
				return "image/gif";
			case "PNG":
				return "image/png";
			case "BMP":
				return "image/bmp";
			default:
				return "application/octet-stream";
			}
		}

		public static string GetMimeType(string fileName)
		{
			fileName = fileName.ToLower();
			if (fileName.EndsWith(".bmp", StringComparison.CurrentCulture))
			{
				return "image/bmp";
			}
			if (fileName.EndsWith(".gif", StringComparison.CurrentCulture))
			{
				return "image/gif";
			}
			if (fileName.EndsWith(".jpg", StringComparison.CurrentCulture) || fileName.EndsWith(".jpeg", StringComparison.CurrentCulture))
			{
				return "image/jpeg";
			}
			if (fileName.EndsWith(".png", StringComparison.CurrentCulture))
			{
				return "image/png";
			}
			return "application/octet-stream";
		}

		public static string GetRootElement(string api)
		{
			int num = api.IndexOf(".");
			if (num != -1 && api.Length > num)
			{
				api = api.Substring(num + 1).Replace('.', '_');
			}
			return api + "_response";
		}

		public static IDictionary ParseJson(string body)
		{
			return JsonConvert.Import(body) as IDictionary;
		}
	}
}

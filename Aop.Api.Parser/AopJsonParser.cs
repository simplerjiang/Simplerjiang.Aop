using Aop.Api.Request;
using Aop.Api.Util;
using Jayrock.Json.Conversion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Serialization;

namespace Aop.Api.Parser
{
	public class AopJsonParser<T> : IAopParser<T> where T : AopResponse
	{
		private static readonly Dictionary<string, Dictionary<string, AopAttribute>> attrs = new Dictionary<string, Dictionary<string, AopAttribute>>();

		protected static readonly DAopConvert AopJsonConvert = delegate(IAopReader reader, Type type)
		{
			object obj = null;
			Dictionary<string, AopAttribute> aopAttributes = GetAopAttributes(type);
			Dictionary<string, AopAttribute>.Enumerator enumerator = aopAttributes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AopAttribute value = enumerator.Current.Value;
				string itemName = value.ItemName;
				string listName = value.ListName;
				if (reader.HasReturnField(itemName) || (!string.IsNullOrEmpty(listName) && reader.HasReturnField(listName)))
				{
					object obj2 = null;
					if (value.ListType != null)
					{
						obj2 = reader.GetListObjects(listName, itemName, value.ListType, AopJsonConvert);
					}
					else if (typeof(string) == value.ItemType)
					{
						object primitiveObject = reader.GetPrimitiveObject(itemName);
						if (primitiveObject != null)
						{
							obj2 = primitiveObject.ToString();
						}
					}
					else if (typeof(long) != value.ItemType)
					{
						obj2 = ((typeof(bool) != value.ItemType) ? reader.GetReferenceObject(itemName, value.ItemType, AopJsonConvert) : reader.GetPrimitiveObject(itemName));
					}
					else
					{
						object primitiveObject2 = reader.GetPrimitiveObject(itemName);
						if (primitiveObject2 != null)
						{
							obj2 = ((IConvertible)primitiveObject2).ToInt64(null);
						}
					}
					if (obj2 != null)
					{
						if (obj == null)
						{
							obj = Activator.CreateInstance(type);
						}
						value.Method.Invoke(obj, new object[1]
						{
							obj2
						});
					}
				}
			}
			return obj;
		};

		public T Parse(string body, string charset)
		{
			T val = null;
			IDictionary dictionary = JsonConvert.Import(body) as IDictionary;
			if (dictionary != null)
			{
				IDictionary dictionary2 = null;
				foreach (object key in dictionary.Keys)
				{
					dictionary2 = (dictionary[key] as IDictionary);
					if (dictionary2 != null && dictionary2.Count > 0)
					{
						break;
					}
				}
				if (dictionary2 != null)
				{
					IAopReader reader = new AopJsonReader(dictionary2);
					val = (T)AopJsonConvert(reader, typeof(T));
				}
			}
			if (val == null)
			{
				val = Activator.CreateInstance<T>();
			}
			if (val != null)
			{
				val.Body = body;
			}
			return val;
		}

		public SignItem GetSignItem(IAopRequest<T> request, string responseBody)
		{
			if (string.IsNullOrEmpty(responseBody))
			{
				return null;
			}
			SignItem signItem = new SignItem();
			string text = signItem.Sign = GetSign(responseBody);
			string text2 = signItem.SignSourceDate = GetSignSourceData(request, responseBody);
			return signItem;
		}

		private static Dictionary<string, AopAttribute> GetAopAttributes(Type type)
		{
			Dictionary<string, AopAttribute> value = null;
			if (attrs.TryGetValue(type.FullName, out value) && value != null)
			{
				return value;
			}
			value = new Dictionary<string, AopAttribute>();
			PropertyInfo[] properties = type.GetProperties();
			PropertyInfo[] array = properties;
			foreach (PropertyInfo propertyInfo in array)
			{
				AopAttribute aopAttribute = new AopAttribute();
				aopAttribute.Method = propertyInfo.GetSetMethod();
				XmlElementAttribute[] array2 = propertyInfo.GetCustomAttributes(typeof(XmlElementAttribute), inherit: true) as XmlElementAttribute[];
				if (array2 != null && array2.Length != 0)
				{
					aopAttribute.ItemName = array2[0].ElementName;
				}
				if (aopAttribute.ItemName == null)
				{
					XmlArrayItemAttribute[] array3 = propertyInfo.GetCustomAttributes(typeof(XmlArrayItemAttribute), inherit: true) as XmlArrayItemAttribute[];
					if (array3 != null && array3.Length != 0)
					{
						aopAttribute.ItemName = array3[0].ElementName;
					}
					XmlArrayAttribute[] array4 = propertyInfo.GetCustomAttributes(typeof(XmlArrayAttribute), inherit: true) as XmlArrayAttribute[];
					if (array4 != null && array4.Length != 0)
					{
						aopAttribute.ListName = array4[0].ElementName;
					}
					if (aopAttribute.ListName == null)
					{
						continue;
					}
				}
				if (propertyInfo.PropertyType.IsGenericType)
				{
					Type[] genericArguments = propertyInfo.PropertyType.GetGenericArguments();
					aopAttribute.ListType = genericArguments[0];
				}
				else
				{
					aopAttribute.ItemType = propertyInfo.PropertyType;
				}
				value.Add(propertyInfo.Name + aopAttribute.ItemType + aopAttribute.ListType, aopAttribute);
			}
			attrs[type.FullName] = value;
			return value;
		}

		private static string GetSign(string body)
		{
			IDictionary dictionary = JsonConvert.Import(body) as IDictionary;
			Console.WriteLine(dictionary);
			return (string)dictionary["sign"];
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
			int num = indexOfRootNode + rootNode.Length + 2;
			int num2 = body.IndexOf("\"sign\"");
			if (num2 < 0)
			{
				return null;
			}
			int num3 = num2 - 1;
			int length = num3 - num;
			return body.Substring(num, length);
		}

		public string EncryptSourceData(IAopRequest<T> request, string body, string encryptType, string encryptKey, string charset)
		{
			if (!"AES".Equals(encryptType))
			{
				throw new AopException("API only support AES!");
			}
			EncryptParseItem encryptParseItem = parseEncryptData(request, body);
			string str = body.Substring(0, encryptParseItem.startIndex);
			string str2 = body.Substring(encryptParseItem.endIndex);
			string str3 = AlipayEncrypt.AesDencrypt(encryptKey, encryptParseItem.encryptContent, charset);
			return str + str3 + str2;
		}

		private static EncryptParseItem parseEncryptData(IAopRequest<T> request, string body)
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
			int num = indexOfRootNode + rootNode.Length + 2;
			int num2 = body.IndexOf("\"sign\"");
			int num3 = num2 - 1;
			if (num3 < 0)
			{
				num3 = body.Length - 1;
			}
			int num4 = num3 - num;
			string encryptContent = body.Substring(num + 1, num4 - 2);
			EncryptParseItem encryptParseItem = new EncryptParseItem();
			encryptParseItem.encryptContent = encryptContent;
			encryptParseItem.startIndex = num;
			encryptParseItem.endIndex = num3;
			return encryptParseItem;
		}
	}
}

using Jayrock.Json;
using System.Collections;
using System.Reflection;
using System.Xml.Serialization;

namespace Aop.Api.Parser
{
	public class AopModelParser
	{
		public JsonObject serializeAopObject(AopObject res)
		{
			PropertyInfo[] properties = res.GetType().GetProperties();
			JsonObject jsonObject = new JsonObject();
			PropertyInfo[] array = properties;
			foreach (PropertyInfo propertyInfo in array)
			{
				if (!propertyInfo.CanRead)
				{
					continue;
				}
				string elementName = getElementName(propertyInfo);
				object piValue = getPiValue(res, propertyInfo);
				if (!string.IsNullOrEmpty(elementName))
				{
					object obj = serializeValue(piValue);
					if (obj != null)
					{
						jsonObject.Put(elementName, obj);
					}
				}
			}
			return jsonObject;
		}

		private object serializeValue(object value)
		{
			if (value == null)
			{
				return null;
			}
			object obj = null;
			return (value is IDictionary) ? serializeDicValue((IDictionary)value) : ((!(value is ICollection)) ? serializeElementValue(value) : serializeArrayValue((ICollection)value));
		}

		private object serializeElementValue(object value)
		{
			if (value == null)
			{
				return null;
			}
			object obj = null;
			return (!(value is AopObject)) ? value : serializeAopObject((AopObject)value);
		}

		private object serializeDicValue(IDictionary dic)
		{
			if (dic == null)
			{
				return null;
			}
			JsonObject jsonObject = new JsonObject();
			foreach (string key in dic.Keys)
			{
				object value = dic[key];
				object value2 = serializeValue(value);
				jsonObject.Put(key, value2);
			}
			return jsonObject;
		}

		private object serializeArrayValue(ICollection collection)
		{
			if (collection == null)
			{
				return null;
			}
			JsonArray jsonArray = new JsonArray();
			foreach (object item in collection)
			{
				jsonArray.Add(serializeValue(item));
			}
			return jsonArray;
		}

		private object getPiValue(object res, PropertyInfo pi)
		{
			if (!pi.CanRead)
			{
				return null;
			}
			return pi.GetValue(res, null);
		}

		private string getElementName(PropertyInfo pi)
		{
			if (pi == null)
			{
				return null;
			}
			XmlElementAttribute[] array = pi.GetCustomAttributes(typeof(XmlElementAttribute), inherit: true) as XmlElementAttribute[];
			string text = null;
			if (array != null && array.Length != 0)
			{
				text = array[0].ElementName;
			}
			if (string.IsNullOrEmpty(text))
			{
				XmlArrayAttribute[] array2 = pi.GetCustomAttributes(typeof(XmlArrayAttribute), inherit: true) as XmlArrayAttribute[];
				if (array2 != null && array2.Length != 0)
				{
					text = array2[0].ElementName;
				}
			}
			return text;
		}
	}
}

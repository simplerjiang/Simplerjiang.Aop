using System;
using System.Collections;
using System.Reflection;

namespace Aop.Api.Util
{
	public class StringUtil
	{
		public static string ToString(object obj)
		{
			if (obj == null)
			{
				return "null";
			}
			Type type = obj.GetType();
			if (string.Equals("System", type.Namespace))
			{
				return "\"" + obj.ToString() + "\"";
			}
			string str = "{";
			PropertyInfo[] properties = type.GetProperties();
			for (int i = 0; i < properties.Length; i++)
			{
				PropertyInfo propertyInfo = properties[i];
				Type propertyType = propertyInfo.PropertyType;
				MethodInfo getMethod = propertyInfo.GetGetMethod();
				object obj2 = getMethod.Invoke(obj, null);
				if (obj2 != null)
				{
					string text = "";
					text = (string.Equals("System", propertyType.Namespace) ? ("\"" + obj2.ToString() + "\"") : ((!string.Equals("System.Collections.Generic", propertyType.Namespace)) ? ToString(obj2) : List2String(obj2)));
					if (i != 0)
					{
						str += ",";
					}
					str += "\"" + propertyInfo.Name + "\":" + text;
				}
			}
			return str + "}";
		}

		public static string List2String(object listObjects)
		{
			if (listObjects == null)
			{
				return "[]";
			}
			string str = "[";
			IList list = (IList)listObjects;
			for (int i = 0; i < list.Count; i++)
			{
				if (i != 0)
				{
					str += ",";
				}
				str += ToString(list[i]);
			}
			return str + "]";
		}
	}
}

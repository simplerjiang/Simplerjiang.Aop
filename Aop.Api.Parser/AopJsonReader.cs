using Jayrock.Json;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Aop.Api.Parser
{
	public class AopJsonReader : IAopReader
	{
		private IDictionary json;

		public AopJsonReader(IDictionary json)
		{
			this.json = json;
		}

		public bool HasReturnField(object name)
		{
			return json.Contains(name);
		}

		public object GetPrimitiveObject(object name)
		{
			return json[name];
		}

		public object GetReferenceObject(object name, Type type, DAopConvert convert)
		{
			IDictionary dictionary = json[name] as IDictionary;
			if (dictionary != null && dictionary.Count > 0)
			{
				return convert(new AopJsonReader(dictionary), type);
			}
			return null;
		}

		public IList GetListObjects(string listName, string itemName, Type type, DAopConvert convert)
		{
			IList list = null;
			object obj = json[listName];
			IList list2 = null;
			if (obj is IList)
			{
				list2 = (obj as IList);
			}
			else if (obj is IDictionary)
			{
				IDictionary dictionary = obj as IDictionary;
				if (dictionary != null && dictionary.Count > 0)
				{
					object obj2 = dictionary[itemName];
					if (obj2 == null && listName != null)
					{
						obj2 = dictionary[listName.Substring(0, listName.Length - 1)];
					}
					if (obj2 is IList)
					{
						list2 = (obj2 as IList);
					}
				}
			}
			if (list2 != null && list2.Count > 0)
			{
				Type type2 = typeof(List<>).MakeGenericType(type);
				list = (Activator.CreateInstance(type2) as IList);
				foreach (object item in list2)
				{
					if (typeof(IDictionary).IsAssignableFrom(item.GetType()))
					{
						IDictionary dictionary2 = item as IDictionary;
						object obj3 = convert(new AopJsonReader(dictionary2), type);
						if (obj3 != null)
						{
							list.Add(obj3);
						}
					}
					else if (!typeof(IList).IsAssignableFrom(item.GetType()))
					{
						if (typeof(JsonNumber).IsAssignableFrom(item.GetType()))
						{
							JsonNumber jsonNumber = (JsonNumber)item;
							if (typeof(long).IsAssignableFrom(type))
							{
								list.Add(jsonNumber.ToInt64());
							}
							else if (typeof(int).IsAssignableFrom(type))
							{
								list.Add(jsonNumber.ToInt32());
							}
							else if (typeof(double).IsAssignableFrom(type))
							{
								list.Add(jsonNumber.ToDouble());
							}
						}
						else
						{
							list.Add(item);
						}
					}
				}
			}
			return list;
		}
	}
}

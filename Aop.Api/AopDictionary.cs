using System;
using System.Collections.Generic;

namespace Aop.Api
{
	public class AopDictionary : Dictionary<string, string>
	{
		private const string DATE_TIME_FORMAT = "yyyy-MM-dd HH:mm:ss";

		public AopDictionary()
		{
		}

		public AopDictionary(IDictionary<string, string> dictionary)
			: base(dictionary)
		{
		}

		public void Add(string key, object value)
		{
			string value2 = (value == null) ? null : ((value is string) ? ((string)value) : ((value is DateTime?) ? (value as DateTime?).Value.ToString("yyyy-MM-dd HH:mm:ss") : ((value is int?) ? (value as int?).Value.ToString() : ((value is long?) ? (value as long?).Value.ToString() : ((value is double?) ? (value as double?).Value.ToString() : ((!(value is bool?)) ? value.ToString() : (value as bool?).Value.ToString().ToLower()))))));
			Add(key, value2);
		}

		public new void Add(string key, string value)
		{
			if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
			{
				base.Add(key, value);
			}
		}
	}
}

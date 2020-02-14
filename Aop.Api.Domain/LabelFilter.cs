using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class LabelFilter : AopObject
	{
		[XmlElement("column_name")]
		public string ColumnName
		{
			get;
			set;
		}

		[XmlElement("op")]
		public string Op
		{
			get;
			set;
		}

		[XmlArray("values")]
		[XmlArrayItem("string")]
		public List<string> Values
		{
			get;
			set;
		}
	}
}

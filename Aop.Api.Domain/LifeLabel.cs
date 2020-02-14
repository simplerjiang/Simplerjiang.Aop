using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class LifeLabel : AopObject
	{
		[XmlElement("biz")]
		public string Biz
		{
			get;
			set;
		}

		[XmlElement("category")]
		public string Category
		{
			get;
			set;
		}

		[XmlElement("data_type")]
		public string DataType
		{
			get;
			set;
		}

		[XmlElement("label_code")]
		public string LabelCode
		{
			get;
			set;
		}

		[XmlElement("label_id")]
		public string LabelId
		{
			get;
			set;
		}

		[XmlElement("label_name")]
		public string LabelName
		{
			get;
			set;
		}

		[XmlElement("operator")]
		public string Operator
		{
			get;
			set;
		}

		[XmlArray("options")]
		[XmlArrayItem("option")]
		public List<Option> Options
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class QueryLabelRule : AopObject
	{
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

		[XmlElement("label_value")]
		public string LabelValue
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
	}
}

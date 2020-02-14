using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Condition : AopObject
	{
		[XmlElement("field_name")]
		public string FieldName
		{
			get;
			set;
		}

		[XmlElement("field_value")]
		public string FieldValue
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

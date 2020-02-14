using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ExtendFieldInfo : AopObject
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
	}
}

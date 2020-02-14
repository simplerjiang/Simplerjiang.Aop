using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsObject : AopObject
	{
		[XmlElement("insured_object_id")]
		public string InsuredObjectId
		{
			get;
			set;
		}

		[XmlElement("insured_object_info")]
		public string InsuredObjectInfo
		{
			get;
			set;
		}

		[XmlElement("type")]
		public long Type
		{
			get;
			set;
		}
	}
}

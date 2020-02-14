using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CplifeResidentInfo : AopObject
	{
		[XmlElement("entity_id")]
		public string EntityId
		{
			get;
			set;
		}

		[XmlElement("idcard_no")]
		public string IdcardNo
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("out_entity_id")]
		public string OutEntityId
		{
			get;
			set;
		}

		[XmlElement("out_resident_id")]
		public string OutResidentId
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

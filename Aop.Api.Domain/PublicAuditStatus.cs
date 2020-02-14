using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PublicAuditStatus : AopObject
	{
		[XmlElement("desc")]
		public string Desc
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
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

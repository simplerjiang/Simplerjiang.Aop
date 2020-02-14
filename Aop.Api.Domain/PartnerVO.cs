using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PartnerVO : AopObject
	{
		[XmlElement("biz_status")]
		public string BizStatus
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
		{
			get;
			set;
		}

		[XmlElement("partner_name")]
		public string PartnerName
		{
			get;
			set;
		}

		[XmlElement("short_code")]
		public string ShortCode
		{
			get;
			set;
		}
	}
}

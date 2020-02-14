using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ExtendParams : AopObject
	{
		[XmlElement("card_type")]
		public string CardType
		{
			get;
			set;
		}

		[XmlElement("hb_fq_num")]
		public string HbFqNum
		{
			get;
			set;
		}

		[XmlElement("hb_fq_seller_percent")]
		public string HbFqSellerPercent
		{
			get;
			set;
		}

		[XmlElement("industry_reflux_info")]
		public string IndustryRefluxInfo
		{
			get;
			set;
		}

		[XmlElement("sys_service_provider_id")]
		public string SysServiceProviderId
		{
			get;
			set;
		}
	}
}

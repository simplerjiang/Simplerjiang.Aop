using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskRainscoreQueryModel : AopObject
	{
		[XmlElement("account")]
		public string Account
		{
			get;
			set;
		}

		[XmlElement("account_type")]
		public string AccountType
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

		[XmlElement("version")]
		public string Version
		{
			get;
			set;
		}
	}
}

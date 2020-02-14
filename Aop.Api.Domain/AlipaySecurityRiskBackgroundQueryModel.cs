using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskBackgroundQueryModel : AopObject
	{
		[XmlElement("params")]
		public string Params
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
	}
}

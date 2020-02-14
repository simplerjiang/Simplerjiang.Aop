using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdAmlriskQueryResponse : AopResponse
	{
		[XmlElement("event_id")]
		public string EventId
		{
			get;
			set;
		}

		[XmlElement("has_risk")]
		public string HasRisk
		{
			get;
			set;
		}

		[XmlElement("merchant_id")]
		public string MerchantId
		{
			get;
			set;
		}

		[XmlArray("risks")]
		[XmlArrayItem("merchant_screen_hit")]
		public List<MerchantScreenHit> Risks
		{
			get;
			set;
		}
	}
}

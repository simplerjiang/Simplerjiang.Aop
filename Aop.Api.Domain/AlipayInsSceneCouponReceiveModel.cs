using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsSceneCouponReceiveModel : AopObject
	{
		[XmlElement("applicant")]
		public InsPerson Applicant
		{
			get;
			set;
		}

		[XmlElement("certificate")]
		public InsCertificate Certificate
		{
			get;
			set;
		}

		[XmlElement("insured")]
		public InsPerson Insured
		{
			get;
			set;
		}

		[XmlElement("market_type")]
		public string MarketType
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
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

		[XmlElement("prod_code")]
		public string ProdCode
		{
			get;
			set;
		}

		[XmlElement("prod_version")]
		public string ProdVersion
		{
			get;
			set;
		}

		[XmlElement("service_scenario")]
		public string ServiceScenario
		{
			get;
			set;
		}
	}
}

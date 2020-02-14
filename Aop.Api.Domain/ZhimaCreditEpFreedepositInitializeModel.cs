using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaCreditEpFreedepositInitializeModel : AopObject
	{
		[XmlElement("biz_channel")]
		public string BizChannel
		{
			get;
			set;
		}

		[XmlElement("biz_source")]
		public string BizSource
		{
			get;
			set;
		}

		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("cert_type")]
		public string CertType
		{
			get;
			set;
		}

		[XmlElement("credit_category")]
		public string CreditCategory
		{
			get;
			set;
		}

		[XmlElement("ep_cert_no")]
		public string EpCertNo
		{
			get;
			set;
		}

		[XmlElement("ep_cert_type")]
		public string EpCertType
		{
			get;
			set;
		}

		[XmlElement("ep_name")]
		public string EpName
		{
			get;
			set;
		}

		[XmlElement("goto_url")]
		public string GotoUrl
		{
			get;
			set;
		}

		[XmlElement("merchant_order_no")]
		public string MerchantOrderNo
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

		[XmlElement("out_request_no")]
		public string OutRequestNo
		{
			get;
			set;
		}

		[XmlElement("product_code")]
		public string ProductCode
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}
	}
}

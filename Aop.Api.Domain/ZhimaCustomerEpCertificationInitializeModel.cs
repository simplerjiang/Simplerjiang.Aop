using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaCustomerEpCertificationInitializeModel : AopObject
	{
		[XmlElement("biz_code")]
		public string BizCode
		{
			get;
			set;
		}

		[XmlElement("ext_biz_param")]
		public string ExtBizParam
		{
			get;
			set;
		}

		[XmlElement("identity_param")]
		public string IdentityParam
		{
			get;
			set;
		}

		[XmlElement("merchant_config")]
		public string MerchantConfig
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

		[XmlElement("transaction_id")]
		public string TransactionId
		{
			get;
			set;
		}
	}
}

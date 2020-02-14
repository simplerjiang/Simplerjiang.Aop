using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaCreditScoreBriefGetModel : AopObject
	{
		[XmlElement("admittance_score")]
		public long AdmittanceScore
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

		[XmlElement("linked_merchant_id")]
		public string LinkedMerchantId
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

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaCreditRelationQueryModel : AopObject
	{
		[XmlElement("cert_no")]
		public string CertNo
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

		[XmlElement("relation")]
		public string Relation
		{
			get;
			set;
		}

		[XmlElement("relation_name")]
		public string RelationName
		{
			get;
			set;
		}

		[XmlElement("relation_phone")]
		public string RelationPhone
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

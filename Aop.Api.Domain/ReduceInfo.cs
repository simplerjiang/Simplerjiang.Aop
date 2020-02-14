using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ReduceInfo : AopObject
	{
		[XmlElement("brand_name")]
		public string BrandName
		{
			get;
			set;
		}

		[XmlElement("consume_amt")]
		public string ConsumeAmt
		{
			get;
			set;
		}

		[XmlElement("consume_store_name")]
		public string ConsumeStoreName
		{
			get;
			set;
		}

		[XmlElement("payment_time")]
		public string PaymentTime
		{
			get;
			set;
		}

		[XmlElement("promo_amt")]
		public string PromoAmt
		{
			get;
			set;
		}

		[XmlElement("user_name")]
		public string UserName
		{
			get;
			set;
		}
	}
}

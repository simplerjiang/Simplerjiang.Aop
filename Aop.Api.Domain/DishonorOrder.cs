using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DishonorOrder : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("dishonor_date")]
		public string DishonorDate
		{
			get;
			set;
		}

		[XmlElement("fail_reason")]
		public string FailReason
		{
			get;
			set;
		}

		[XmlElement("order_id")]
		public string OrderId
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

		[XmlElement("pay_date")]
		public string PayDate
		{
			get;
			set;
		}

		[XmlElement("payer_account")]
		public string PayerAccount
		{
			get;
			set;
		}

		[XmlElement("payment_no")]
		public string PaymentNo
		{
			get;
			set;
		}
	}
}

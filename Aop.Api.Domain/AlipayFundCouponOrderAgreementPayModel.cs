using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayFundCouponOrderAgreementPayModel : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("extra_param")]
		public string ExtraParam
		{
			get;
			set;
		}

		[XmlElement("order_title")]
		public string OrderTitle
		{
			get;
			set;
		}

		[XmlElement("out_order_no")]
		public string OutOrderNo
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

		[XmlElement("pay_timeout")]
		public string PayTimeout
		{
			get;
			set;
		}

		[XmlElement("payer_user_id")]
		public string PayerUserId
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaMerchantOrderCreditPayModel : AopObject
	{
		[XmlElement("coupon_amount")]
		public string CouponAmount
		{
			get;
			set;
		}

		[XmlElement("order_operate_type")]
		public string OrderOperateType
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

		[XmlElement("out_trans_no")]
		public string OutTransNo
		{
			get;
			set;
		}

		[XmlElement("pay_amount")]
		public string PayAmount
		{
			get;
			set;
		}

		[XmlElement("remark")]
		public string Remark
		{
			get;
			set;
		}

		[XmlElement("use_coupon")]
		public string UseCoupon
		{
			get;
			set;
		}

		[XmlElement("zm_order_no")]
		public string ZmOrderNo
		{
			get;
			set;
		}
	}
}

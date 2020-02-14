using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaMerchantOrderRentQueryResponse : AopResponse
	{
		[XmlElement("admit_state")]
		public string AdmitState
		{
			get;
			set;
		}

		[XmlElement("alipay_fund_order_no")]
		public string AlipayFundOrderNo
		{
			get;
			set;
		}

		[XmlElement("borrow_time")]
		public string BorrowTime
		{
			get;
			set;
		}

		[XmlElement("goods_name")]
		public string GoodsName
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
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

		[XmlElement("pay_amount_type")]
		public string PayAmountType
		{
			get;
			set;
		}

		[XmlElement("pay_status")]
		public string PayStatus
		{
			get;
			set;
		}

		[XmlElement("pay_time")]
		public string PayTime
		{
			get;
			set;
		}

		[XmlElement("restore_time")]
		public string RestoreTime
		{
			get;
			set;
		}

		[XmlElement("use_state")]
		public string UseState
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}

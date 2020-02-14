using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaMerchantOrderRentCreateModel : AopObject
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("borrow_cycle")]
		public string BorrowCycle
		{
			get;
			set;
		}

		[XmlElement("borrow_cycle_unit")]
		public string BorrowCycleUnit
		{
			get;
			set;
		}

		[XmlElement("borrow_shop_name")]
		public string BorrowShopName
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

		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("credit_biz")]
		public string CreditBiz
		{
			get;
			set;
		}

		[XmlElement("deposit_amount")]
		public string DepositAmount
		{
			get;
			set;
		}

		[XmlElement("deposit_state")]
		public string DepositState
		{
			get;
			set;
		}

		[XmlElement("expiry_time")]
		public string ExpiryTime
		{
			get;
			set;
		}

		[XmlElement("extend_info")]
		public string ExtendInfo
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

		[XmlElement("invoke_return_url")]
		public string InvokeReturnUrl
		{
			get;
			set;
		}

		[XmlElement("invoke_state")]
		public string InvokeState
		{
			get;
			set;
		}

		[XmlElement("invoke_type")]
		public string InvokeType
		{
			get;
			set;
		}

		[XmlElement("mobile_no")]
		public string MobileNo
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

		[XmlElement("notify_url")]
		public string NotifyUrl
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

		[XmlElement("product_code")]
		public string ProductCode
		{
			get;
			set;
		}

		[XmlElement("rent_amount")]
		public string RentAmount
		{
			get;
			set;
		}

		[XmlElement("rent_info")]
		public string RentInfo
		{
			get;
			set;
		}

		[XmlElement("rent_settle_type")]
		public string RentSettleType
		{
			get;
			set;
		}

		[XmlElement("rent_unit")]
		public string RentUnit
		{
			get;
			set;
		}
	}
}

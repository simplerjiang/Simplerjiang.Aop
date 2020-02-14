using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradeAppPayModel : AopObject
	{
		[XmlElement("body")]
		public string Body
		{
			get;
			set;
		}

		[XmlElement("business_params")]
		public string BusinessParams
		{
			get;
			set;
		}

		[XmlElement("disable_pay_channels")]
		public string DisablePayChannels
		{
			get;
			set;
		}

		[XmlElement("enable_pay_channels")]
		public string EnablePayChannels
		{
			get;
			set;
		}

		[XmlElement("ext_user_info")]
		public ExtUserInfo ExtUserInfo
		{
			get;
			set;
		}

		[XmlElement("extend_params")]
		public ExtendParams ExtendParams
		{
			get;
			set;
		}

		[XmlElement("goods_type")]
		public string GoodsType
		{
			get;
			set;
		}

		[XmlElement("invoice_info")]
		public InvoiceInfo InvoiceInfo
		{
			get;
			set;
		}

		[XmlElement("out_trade_no")]
		public string OutTradeNo
		{
			get;
			set;
		}

		[XmlElement("passback_params")]
		public string PassbackParams
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

		[XmlElement("promo_params")]
		public string PromoParams
		{
			get;
			set;
		}

		[XmlElement("royalty_info")]
		public RoyaltyInfo RoyaltyInfo
		{
			get;
			set;
		}

		[XmlElement("seller_id")]
		public string SellerId
		{
			get;
			set;
		}

		[XmlElement("settle_info")]
		public SettleInfo SettleInfo
		{
			get;
			set;
		}

		[XmlElement("specified_channel")]
		public string SpecifiedChannel
		{
			get;
			set;
		}

		[XmlElement("store_id")]
		public string StoreId
		{
			get;
			set;
		}

		[XmlElement("sub_merchant")]
		public SubMerchant SubMerchant
		{
			get;
			set;
		}

		[XmlElement("subject")]
		public string Subject
		{
			get;
			set;
		}

		[XmlElement("time_expire")]
		public string TimeExpire
		{
			get;
			set;
		}

		[XmlElement("timeout_express")]
		public string TimeoutExpress
		{
			get;
			set;
		}

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}
	}
}

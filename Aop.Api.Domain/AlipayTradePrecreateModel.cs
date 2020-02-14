using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradePrecreateModel : AopObject
	{
		[XmlElement("alipay_store_id")]
		public string AlipayStoreId
		{
			get;
			set;
		}

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

		[XmlElement("buyer_logon_id")]
		public string BuyerLogonId
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

		[XmlElement("discountable_amount")]
		public string DiscountableAmount
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

		[XmlArray("goods_detail")]
		[XmlArrayItem("goods_detail")]
		public List<GoodsDetail> GoodsDetail
		{
			get;
			set;
		}

		[XmlElement("operator_id")]
		public string OperatorId
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

		[XmlElement("qr_code_timeout_express")]
		public string QrCodeTimeoutExpress
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

		[XmlElement("terminal_id")]
		public string TerminalId
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

		[XmlElement("undiscountable_amount")]
		public string UndiscountableAmount
		{
			get;
			set;
		}
	}
}

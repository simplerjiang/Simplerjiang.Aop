using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradePayModel : AopObject
	{
		[XmlElement("agreement_params")]
		public AgreementParams AgreementParams
		{
			get;
			set;
		}

		[XmlElement("alipay_store_id")]
		public string AlipayStoreId
		{
			get;
			set;
		}

		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}

		[XmlElement("auth_confirm_mode")]
		public string AuthConfirmMode
		{
			get;
			set;
		}

		[XmlElement("auth_no")]
		public string AuthNo
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

		[XmlElement("buyer_id")]
		public string BuyerId
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

		[XmlElement("merchant_order_no")]
		public string MerchantOrderNo
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

		[XmlElement("product_code")]
		public string ProductCode
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

		[XmlElement("scene")]
		public string Scene
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

		[XmlElement("settle_currency")]
		public string SettleCurrency
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

		[XmlElement("terminal_params")]
		public string TerminalParams
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

		[XmlElement("trans_currency")]
		public string TransCurrency
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

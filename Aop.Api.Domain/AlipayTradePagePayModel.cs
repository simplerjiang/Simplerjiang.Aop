using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradePagePayModel : AopObject
	{
		[XmlElement("agreement_sign_params")]
		public AgreementSignParams AgreementSignParams
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

		[XmlArray("goods_detail")]
		[XmlArrayItem("goods_detail")]
		public List<GoodsDetail> GoodsDetail
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

		[XmlElement("integration_type")]
		public string IntegrationType
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

		[XmlElement("qr_pay_mode")]
		public string QrPayMode
		{
			get;
			set;
		}

		[XmlElement("qrcode_width")]
		public long QrcodeWidth
		{
			get;
			set;
		}

		[XmlElement("request_from_url")]
		public string RequestFromUrl
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

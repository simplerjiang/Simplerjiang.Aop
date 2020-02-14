using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiItemCreateModel : AopObject
	{
		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}

		[XmlElement("category_id")]
		public string CategoryId
		{
			get;
			set;
		}

		[XmlElement("cover")]
		public string Cover
		{
			get;
			set;
		}

		[XmlArray("descriptions")]
		[XmlArrayItem("koubei_item_description")]
		public List<KoubeiItemDescription> Descriptions
		{
			get;
			set;
		}

		[XmlElement("gmt_end")]
		public string GmtEnd
		{
			get;
			set;
		}

		[XmlElement("gmt_start")]
		public string GmtStart
		{
			get;
			set;
		}

		[XmlElement("inventory")]
		public long Inventory
		{
			get;
			set;
		}

		[XmlElement("item_detail_url")]
		public string ItemDetailUrl
		{
			get;
			set;
		}

		[XmlElement("item_type")]
		public string ItemType
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("operation_context")]
		public KoubeiOperationContext OperationContext
		{
			get;
			set;
		}

		[XmlElement("original_price")]
		public string OriginalPrice
		{
			get;
			set;
		}

		[XmlElement("picture_details")]
		public string PictureDetails
		{
			get;
			set;
		}

		[XmlElement("price")]
		public string Price
		{
			get;
			set;
		}

		[XmlElement("price_mode")]
		public string PriceMode
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
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

		[XmlElement("shop_ids")]
		public string ShopIds
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

		[XmlElement("tb_cover")]
		public string TbCover
		{
			get;
			set;
		}

		[XmlElement("trade_voucher_item_template")]
		public KoubeiTradeVoucherItemTemplete TradeVoucherItemTemplate
		{
			get;
			set;
		}

		[XmlElement("weight")]
		public string Weight
		{
			get;
			set;
		}
	}
}

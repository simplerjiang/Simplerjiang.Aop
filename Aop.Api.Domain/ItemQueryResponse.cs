using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ItemQueryResponse : AopObject
	{
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

		[XmlElement("item_id")]
		public string ItemId
		{
			get;
			set;
		}

		[XmlElement("item_status")]
		public string ItemStatus
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

		[XmlElement("original_price")]
		public string OriginalPrice
		{
			get;
			set;
		}

		[XmlArray("pic_coll")]
		[XmlArrayItem("string")]
		public List<string> PicColl
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
		public long Weight
		{
			get;
			set;
		}
	}
}

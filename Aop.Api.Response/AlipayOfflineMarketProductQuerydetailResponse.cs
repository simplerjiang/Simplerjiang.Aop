using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMarketProductQuerydetailResponse : AopResponse
	{
		[XmlElement("cover")]
		public string Cover
		{
			get;
			set;
		}

		[XmlArray("descriptions")]
		[XmlArrayItem("alipay_data_item_description")]
		public List<AlipayDataItemDescription> Descriptions
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

		[XmlElement("is_auto_expanded")]
		public bool IsAutoExpanded
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

		[XmlElement("pic_coll")]
		public string PicColl
		{
			get;
			set;
		}

		[XmlElement("purchase_mode")]
		public string PurchaseMode
		{
			get;
			set;
		}

		[XmlElement("sales_rule")]
		public AlipayDataItemSalesRule SalesRule
		{
			get;
			set;
		}

		[XmlArray("shop_list")]
		[XmlArrayItem("string")]
		public List<string> ShopList
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

		[XmlElement("voucher_templete")]
		public AlipayDataItemVoucherTemplete VoucherTemplete
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

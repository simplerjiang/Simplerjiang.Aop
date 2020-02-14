using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PromoVoucherInfo : AopObject
	{
		[XmlElement("discount")]
		public string Discount
		{
			get;
			set;
		}

		[XmlElement("is_auto_obtain")]
		public string IsAutoObtain
		{
			get;
			set;
		}

		[XmlElement("is_mall_voucher")]
		public string IsMallVoucher
		{
			get;
			set;
		}

		[XmlElement("item_brand_name")]
		public string ItemBrandName
		{
			get;
			set;
		}

		[XmlElement("item_gmt_end")]
		public string ItemGmtEnd
		{
			get;
			set;
		}

		[XmlElement("item_gmt_start")]
		public string ItemGmtStart
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

		[XmlElement("item_logo")]
		public string ItemLogo
		{
			get;
			set;
		}

		[XmlElement("item_name")]
		public string ItemName
		{
			get;
			set;
		}

		[XmlElement("send_item_name")]
		public string SendItemName
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("shop_name")]
		public string ShopName
		{
			get;
			set;
		}

		[XmlElement("use_condition_amount")]
		public string UseConditionAmount
		{
			get;
			set;
		}

		[XmlElement("value_amount")]
		public string ValueAmount
		{
			get;
			set;
		}

		[XmlElement("voucher_detail_url")]
		public string VoucherDetailUrl
		{
			get;
			set;
		}

		[XmlElement("voucher_type")]
		public string VoucherType
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class VoucherRec : AopObject
	{
		[XmlElement("all_keep_count")]
		public string AllKeepCount
		{
			get;
			set;
		}

		[XmlElement("code")]
		public string Code
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

		[XmlElement("crowds")]
		public string Crowds
		{
			get;
			set;
		}

		[XmlElement("discount")]
		public string Discount
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("has_crowd")]
		public string HasCrowd
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

		[XmlElement("item_name")]
		public string ItemName
		{
			get;
			set;
		}

		[XmlElement("item_quantity")]
		public string ItemQuantity
		{
			get;
			set;
		}

		[XmlElement("item_sales_mode")]
		public string ItemSalesMode
		{
			get;
			set;
		}

		[XmlElement("item_sold_quantity")]
		public string ItemSoldQuantity
		{
			get;
			set;
		}

		[XmlElement("original_amount")]
		public string OriginalAmount
		{
			get;
			set;
		}

		[XmlElement("per_value_amount")]
		public string PerValueAmount
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

		[XmlElement("price_mode")]
		public string PriceMode
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

		[XmlElement("threshold_amount")]
		public string ThresholdAmount
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

		[XmlElement("valid_times")]
		public string ValidTimes
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

		[XmlElement("voucher_logo_url")]
		public string VoucherLogoUrl
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

using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringItemQueryResponse : AopResponse
	{
		[XmlArray("available_periods")]
		[XmlArrayItem("available_period_info")]
		public List<AvailablePeriodInfo> AvailablePeriods
		{
			get;
			set;
		}

		[XmlArray("buyer_notes")]
		[XmlArrayItem("buyer_notes_info")]
		public List<BuyerNotesInfo> BuyerNotes
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

		[XmlElement("external_code_inventory_id")]
		public string ExternalCodeInventoryId
		{
			get;
			set;
		}

		[XmlElement("external_code_template_id")]
		public string ExternalCodeTemplateId
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

		[XmlArray("item_dishes")]
		[XmlArrayItem("item_dish_info")]
		public List<ItemDishInfo> ItemDishes
		{
			get;
			set;
		}

		[XmlElement("item_display_channel")]
		public string ItemDisplayChannel
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

		[XmlArray("item_packages")]
		[XmlArrayItem("item_package_info")]
		public List<ItemPackageInfo> ItemPackages
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

		[XmlElement("latest_notice")]
		public string LatestNotice
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

		[XmlElement("merchant_introduction")]
		public IntroductionInfo MerchantIntroduction
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

		[XmlArray("package_notes")]
		[XmlArrayItem("string")]
		public List<string> PackageNotes
		{
			get;
			set;
		}

		[XmlArray("picture_details")]
		[XmlArrayItem("string")]
		public List<string> PictureDetails
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

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}

		[XmlArray("shop_ids")]
		[XmlArrayItem("string")]
		public List<string> ShopIds
		{
			get;
			set;
		}

		[XmlElement("sku_id")]
		public string SkuId
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

		[XmlElement("taobao_cover_image")]
		public string TaobaoCoverImage
		{
			get;
			set;
		}

		[XmlElement("ticket_display_mode")]
		public string TicketDisplayMode
		{
			get;
			set;
		}

		[XmlArray("unavailable_periods")]
		[XmlArrayItem("unavailable_period_info")]
		public List<UnavailablePeriodInfo> UnavailablePeriods
		{
			get;
			set;
		}

		[XmlElement("validity_period")]
		public long ValidityPeriod
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

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignRetailDmModifyModel : AopObject
	{
		[XmlElement("action_url")]
		public string ActionUrl
		{
			get;
			set;
		}

		[XmlElement("activity_end_time")]
		public string ActivityEndTime
		{
			get;
			set;
		}

		[XmlElement("activity_start_time")]
		public string ActivityStartTime
		{
			get;
			set;
		}

		[XmlElement("brief")]
		public string Brief
		{
			get;
			set;
		}

		[XmlElement("campaign_end_time")]
		public string CampaignEndTime
		{
			get;
			set;
		}

		[XmlElement("campaign_type")]
		public string CampaignType
		{
			get;
			set;
		}

		[XmlElement("content_id")]
		public string ContentId
		{
			get;
			set;
		}

		[XmlElement("coupon_type")]
		public string CouponType
		{
			get;
			set;
		}

		[XmlElement("description")]
		public string Description
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

		[XmlElement("image_id")]
		public string ImageId
		{
			get;
			set;
		}

		[XmlElement("item_brand")]
		public string ItemBrand
		{
			get;
			set;
		}

		[XmlElement("item_category")]
		public string ItemCategory
		{
			get;
			set;
		}

		[XmlElement("item_code")]
		public string ItemCode
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

		[XmlElement("member_only")]
		public string MemberOnly
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

		[XmlElement("thumbnail_image_id")]
		public string ThumbnailImageId
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntlbsKBDiscountInfo : AopObject
	{
		[XmlElement("apply_condition")]
		public string ApplyCondition
		{
			get;
			set;
		}

		[XmlElement("buy_send_desc")]
		public string BuySendDesc
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

		[XmlElement("distance")]
		public string Distance
		{
			get;
			set;
		}

		[XmlElement("end_time")]
		public string EndTime
		{
			get;
			set;
		}

		[XmlElement("image_url")]
		public string ImageUrl
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

		[XmlElement("label")]
		public string Label
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

		[XmlElement("per_price")]
		public string PerPrice
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

		[XmlElement("reason")]
		public string Reason
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

		[XmlElement("sold")]
		public string Sold
		{
			get;
			set;
		}

		[XmlElement("start_time")]
		public string StartTime
		{
			get;
			set;
		}

		[XmlElement("threshold_price")]
		public string ThresholdPrice
		{
			get;
			set;
		}

		[XmlElement("top_price")]
		public string TopPrice
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}

		[XmlElement("vol_type")]
		public string VolType
		{
			get;
			set;
		}
	}
}

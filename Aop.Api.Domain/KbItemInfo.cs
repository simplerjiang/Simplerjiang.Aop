using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbItemInfo : AopObject
	{
		[XmlElement("avg_pop_value")]
		public string AvgPopValue
		{
			get;
			set;
		}

		[XmlElement("begin_time")]
		public string BeginTime
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

		[XmlElement("ext_info")]
		public string ExtInfo
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

		[XmlElement("logo")]
		public string Logo
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

		[XmlElement("quota")]
		public string Quota
		{
			get;
			set;
		}

		[XmlElement("sale_price")]
		public string SalePrice
		{
			get;
			set;
		}

		[XmlElement("shop_distance")]
		public string ShopDistance
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}

		[XmlElement("top")]
		public string Top
		{
			get;
			set;
		}

		[XmlElement("total_quota")]
		public string TotalQuota
		{
			get;
			set;
		}

		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}

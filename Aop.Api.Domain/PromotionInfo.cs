using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PromotionInfo : AopObject
	{
		[XmlElement("brand_name")]
		public string BrandName
		{
			get;
			set;
		}

		[XmlElement("collected")]
		public bool Collected
		{
			get;
			set;
		}

		[XmlElement("collected_count")]
		public long CollectedCount
		{
			get;
			set;
		}

		[XmlElement("detail_url")]
		public string DetailUrl
		{
			get;
			set;
		}

		[XmlElement("icon_url")]
		public string IconUrl
		{
			get;
			set;
		}

		[XmlElement("main_image_url")]
		public string MainImageUrl
		{
			get;
			set;
		}

		[XmlElement("promotion_id")]
		public string PromotionId
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

		[XmlElement("using_condition")]
		public string UsingCondition
		{
			get;
			set;
		}

		[XmlElement("using_scope")]
		public string UsingScope
		{
			get;
			set;
		}

		[XmlElement("valid_date_from")]
		public string ValidDateFrom
		{
			get;
			set;
		}

		[XmlElement("valid_date_to")]
		public string ValidDateTo
		{
			get;
			set;
		}

		[XmlElement("valid_time_text")]
		public string ValidTimeText
		{
			get;
			set;
		}
	}
}

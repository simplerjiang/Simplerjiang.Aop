using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DmActivityShopData : AopObject
	{
		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("gmt_modified")]
		public string GmtModified
		{
			get;
			set;
		}

		[XmlElement("one_day_click_persons")]
		public long OneDayClickPersons
		{
			get;
			set;
		}

		[XmlElement("one_day_click_times")]
		public long OneDayClickTimes
		{
			get;
			set;
		}

		[XmlElement("one_day_exposure_times")]
		public long OneDayExposureTimes
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

		[XmlElement("total_click_persons")]
		public long TotalClickPersons
		{
			get;
			set;
		}

		[XmlElement("total_click_times")]
		public long TotalClickTimes
		{
			get;
			set;
		}

		[XmlElement("total_exposure_times")]
		public long TotalExposureTimes
		{
			get;
			set;
		}
	}
}

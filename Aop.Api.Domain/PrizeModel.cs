using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PrizeModel : AopObject
	{
		[XmlElement("active_time")]
		public string ActiveTime
		{
			get;
			set;
		}

		[XmlElement("available_amount")]
		public string AvailableAmount
		{
			get;
			set;
		}

		[XmlElement("available_count")]
		public long AvailableCount
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

		[XmlArray("discount_by_day_list")]
		[XmlArrayItem("discount_by_day_model")]
		public List<DiscountByDayModel> DiscountByDayList
		{
			get;
			set;
		}

		[XmlArray("discount_list")]
		[XmlArrayItem("discount_model")]
		public List<DiscountModel> DiscountList
		{
			get;
			set;
		}

		[XmlElement("expired_time")]
		public string ExpiredTime
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

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("prize_id")]
		public string PrizeId
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

		[XmlElement("total_amount")]
		public string TotalAmount
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

		[XmlElement("used_count")]
		public long UsedCount
		{
			get;
			set;
		}
	}
}

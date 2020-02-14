using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbdishCookInfo : AopObject
	{
		[XmlElement("area")]
		public string Area
		{
			get;
			set;
		}

		[XmlElement("cook_channel")]
		public string CookChannel
		{
			get;
			set;
		}

		[XmlElement("cook_ext_content")]
		public string CookExtContent
		{
			get;
			set;
		}

		[XmlElement("cook_id")]
		public string CookId
		{
			get;
			set;
		}

		[XmlElement("cook_name")]
		public string CookName
		{
			get;
			set;
		}

		[XmlElement("cook_version")]
		public string CookVersion
		{
			get;
			set;
		}

		[XmlElement("create_user")]
		public string CreateUser
		{
			get;
			set;
		}

		[XmlElement("end_date")]
		public string EndDate
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

		[XmlArray("kb_cook_detail_list")]
		[XmlArrayItem("kbdish_cook_detail_info")]
		public List<KbdishCookDetailInfo> KbCookDetailList
		{
			get;
			set;
		}

		[XmlElement("merchant_id")]
		public string MerchantId
		{
			get;
			set;
		}

		[XmlElement("period_type")]
		public string PeriodType
		{
			get;
			set;
		}

		[XmlElement("period_value")]
		public string PeriodValue
		{
			get;
			set;
		}

		[XmlElement("remarks")]
		public string Remarks
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

		[XmlElement("source_from")]
		public string SourceFrom
		{
			get;
			set;
		}

		[XmlElement("start_date")]
		public string StartDate
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("update_user")]
		public string UpdateUser
		{
			get;
			set;
		}
	}
}

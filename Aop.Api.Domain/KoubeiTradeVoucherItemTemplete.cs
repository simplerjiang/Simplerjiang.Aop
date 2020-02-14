using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiTradeVoucherItemTemplete : AopObject
	{
		[XmlArray("available_time_info_list")]
		[XmlArrayItem("available_time_info")]
		public List<AvailableTimeInfo> AvailableTimeInfoList
		{
			get;
			set;
		}

		[XmlArray("buyer_notes")]
		[XmlArrayItem("koubei_item_description")]
		public List<KoubeiItemDescription> BuyerNotes
		{
			get;
			set;
		}

		[XmlElement("support_book")]
		public string SupportBook
		{
			get;
			set;
		}

		[XmlArray("un_available_time_info_list")]
		[XmlArrayItem("un_available_time_info")]
		public List<UnAvailableTimeInfo> UnAvailableTimeInfoList
		{
			get;
			set;
		}

		[XmlElement("validity_period")]
		public string ValidityPeriod
		{
			get;
			set;
		}

		[XmlElement("validity_period_range_from")]
		public string ValidityPeriodRangeFrom
		{
			get;
			set;
		}

		[XmlElement("validity_period_range_to")]
		public string ValidityPeriodRangeTo
		{
			get;
			set;
		}

		[XmlElement("validity_period_type")]
		public string ValidityPeriodType
		{
			get;
			set;
		}

		[XmlElement("verify_enable_times")]
		public long VerifyEnableTimes
		{
			get;
			set;
		}

		[XmlElement("verify_frequency")]
		public string VerifyFrequency
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MerchantActivityVoucherInfo : AopObject
	{
		[XmlElement("logo")]
		public string Logo
		{
			get;
			set;
		}

		[XmlElement("sub_title")]
		public string SubTitle
		{
			get;
			set;
		}

		[XmlElement("user_introductions")]
		public string UserIntroductions
		{
			get;
			set;
		}

		[XmlElement("valid_days_range_from")]
		public long ValidDaysRangeFrom
		{
			get;
			set;
		}

		[XmlElement("valid_days_range_to")]
		public long ValidDaysRangeTo
		{
			get;
			set;
		}

		[XmlElement("valid_time_range_from")]
		public string ValidTimeRangeFrom
		{
			get;
			set;
		}

		[XmlElement("valid_time_range_to")]
		public string ValidTimeRangeTo
		{
			get;
			set;
		}

		[XmlElement("valid_time_type")]
		public string ValidTimeType
		{
			get;
			set;
		}
	}
}

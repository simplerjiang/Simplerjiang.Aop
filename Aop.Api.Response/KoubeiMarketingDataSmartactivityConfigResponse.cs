using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataSmartactivityConfigResponse : AopResponse
	{
		[XmlElement("activity_type")]
		public string ActivityType
		{
			get;
			set;
		}

		[XmlElement("activity_valid_days")]
		public string ActivityValidDays
		{
			get;
			set;
		}

		[XmlElement("config_code")]
		public string ConfigCode
		{
			get;
			set;
		}

		[XmlElement("crowd_group")]
		public string CrowdGroup
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

		[XmlElement("item_name")]
		public string ItemName
		{
			get;
			set;
		}

		[XmlElement("min_consume")]
		public string MinConsume
		{
			get;
			set;
		}

		[XmlElement("min_cost")]
		public string MinCost
		{
			get;
			set;
		}

		[XmlElement("pro_type")]
		public string ProType
		{
			get;
			set;
		}

		[XmlElement("voucher_type")]
		public string VoucherType
		{
			get;
			set;
		}

		[XmlElement("voucher_valid_days")]
		public string VoucherValidDays
		{
			get;
			set;
		}

		[XmlElement("worth_value")]
		public string WorthValue
		{
			get;
			set;
		}
	}
}

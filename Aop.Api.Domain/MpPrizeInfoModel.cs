using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MpPrizeInfoModel : AopObject
	{
		[XmlElement("certlot_number")]
		public string CertlotNumber
		{
			get;
			set;
		}

		[XmlElement("frequency_count")]
		public string FrequencyCount
		{
			get;
			set;
		}

		[XmlElement("frequency_type")]
		public string FrequencyType
		{
			get;
			set;
		}

		[XmlElement("prize_end_time")]
		public string PrizeEndTime
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

		[XmlElement("prize_max_award_limit")]
		public string PrizeMaxAwardLimit
		{
			get;
			set;
		}

		[XmlElement("prize_name")]
		public string PrizeName
		{
			get;
			set;
		}

		[XmlElement("prize_start_time")]
		public string PrizeStartTime
		{
			get;
			set;
		}

		[XmlElement("prize_total")]
		public string PrizeTotal
		{
			get;
			set;
		}

		[XmlElement("prize_type")]
		public string PrizeType
		{
			get;
			set;
		}
	}
}

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignDrawcampTriggerResponse : AopResponse
	{
		[XmlElement("camp_id")]
		public string CampId
		{
			get;
			set;
		}

		[XmlElement("camp_log_id")]
		public string CampLogId
		{
			get;
			set;
		}

		[XmlElement("display_name")]
		public string DisplayName
		{
			get;
			set;
		}

		[XmlElement("extend_field")]
		public string ExtendField
		{
			get;
			set;
		}

		[XmlElement("prize_flag")]
		public string PrizeFlag
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

		[XmlElement("prize_name")]
		public string PrizeName
		{
			get;
			set;
		}

		[XmlElement("trigger_result")]
		public bool TriggerResult
		{
			get;
			set;
		}
	}
}

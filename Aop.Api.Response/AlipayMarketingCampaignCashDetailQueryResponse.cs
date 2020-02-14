using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignCashDetailQueryResponse : AopResponse
	{
		[XmlElement("camp_status")]
		public string CampStatus
		{
			get;
			set;
		}

		[XmlElement("coupon_name")]
		public string CouponName
		{
			get;
			set;
		}

		[XmlElement("crowd_no")]
		public string CrowdNo
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

		[XmlElement("origin_crowd_no")]
		public string OriginCrowdNo
		{
			get;
			set;
		}

		[XmlElement("prize_msg")]
		public string PrizeMsg
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

		[XmlElement("send_amount")]
		public string SendAmount
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

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}

		[XmlElement("total_count")]
		public long TotalCount
		{
			get;
			set;
		}

		[XmlElement("total_num")]
		public long TotalNum
		{
			get;
			set;
		}
	}
}

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignCashTriggerResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
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

		[XmlElement("error_msg")]
		public string ErrorMsg
		{
			get;
			set;
		}

		[XmlElement("merchant_logo")]
		public string MerchantLogo
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
		{
			get;
			set;
		}

		[XmlElement("prize_amount")]
		public string PrizeAmount
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

		[XmlElement("repeat_trigger_flag")]
		public string RepeatTriggerFlag
		{
			get;
			set;
		}

		[XmlElement("trigger_result")]
		public string TriggerResult
		{
			get;
			set;
		}
	}
}

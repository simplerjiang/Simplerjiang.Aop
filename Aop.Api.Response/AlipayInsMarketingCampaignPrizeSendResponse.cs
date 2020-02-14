using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsMarketingCampaignPrizeSendResponse : AopResponse
	{
		[XmlElement("asset_id")]
		public string AssetId
		{
			get;
			set;
		}

		[XmlElement("compaign_id")]
		public string CompaignId
		{
			get;
			set;
		}

		[XmlElement("coupon_id")]
		public string CouponId
		{
			get;
			set;
		}

		[XmlElement("coupon_type")]
		public string CouponType
		{
			get;
			set;
		}

		[XmlElement("coupon_value")]
		public string CouponValue
		{
			get;
			set;
		}

		[XmlElement("flow_id")]
		public string FlowId
		{
			get;
			set;
		}
	}
}

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignDiscountOperateResponse : AopResponse
	{
		[XmlElement("camp_id")]
		public string CampId
		{
			get;
			set;
		}
	}
}

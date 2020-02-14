using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignDrawcampStatusUpdateResponse : AopResponse
	{
		[XmlElement("camp_result")]
		public bool CampResult
		{
			get;
			set;
		}
	}
}

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignDrawcampUpdateResponse : AopResponse
	{
		[XmlElement("camp_result")]
		public bool CampResult
		{
			get;
			set;
		}
	}
}

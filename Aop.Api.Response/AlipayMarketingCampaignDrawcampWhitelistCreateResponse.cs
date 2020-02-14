using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignDrawcampWhitelistCreateResponse : AopResponse
	{
		[XmlElement("camp_result")]
		public bool CampResult
		{
			get;
			set;
		}
	}
}

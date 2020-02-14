using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignDrawcampCreateResponse : AopResponse
	{
		[XmlElement("camp_id")]
		public string CampId
		{
			get;
			set;
		}
	}
}

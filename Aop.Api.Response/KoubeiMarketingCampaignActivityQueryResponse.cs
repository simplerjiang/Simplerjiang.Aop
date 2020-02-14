using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignActivityQueryResponse : AopResponse
	{
		[XmlElement("camp_detail")]
		public CampDetail CampDetail
		{
			get;
			set;
		}
	}
}

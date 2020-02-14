using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignTagsQueryResponse : AopResponse
	{
		[XmlElement("tags")]
		public string Tags
		{
			get;
			set;
		}
	}
}

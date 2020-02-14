using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignRetailDmModifyResponse : AopResponse
	{
		[XmlElement("content_id")]
		public string ContentId
		{
			get;
			set;
		}
	}
}

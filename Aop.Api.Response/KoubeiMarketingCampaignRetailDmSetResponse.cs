using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignRetailDmSetResponse : AopResponse
	{
		[XmlElement("content_id")]
		public string ContentId
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}
	}
}

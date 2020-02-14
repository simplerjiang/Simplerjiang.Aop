using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignActivityOfflineResponse : AopResponse
	{
		[XmlElement("audit_status")]
		public string AuditStatus
		{
			get;
			set;
		}

		[XmlElement("camp_status")]
		public string CampStatus
		{
			get;
			set;
		}
	}
}

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignCrowdBatchqueryResponse : AopResponse
	{
		[XmlElement("crowd_group_sets")]
		public string CrowdGroupSets
		{
			get;
			set;
		}

		[XmlElement("total_number")]
		public string TotalNumber
		{
			get;
			set;
		}
	}
}

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignCrowdCountResponse : AopResponse
	{
		[XmlElement("dimension_values")]
		public string DimensionValues
		{
			get;
			set;
		}

		[XmlElement("summary_values")]
		public string SummaryValues
		{
			get;
			set;
		}
	}
}

using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignActivityBatchqueryResponse : AopResponse
	{
		[XmlArray("camp_sets")]
		[XmlArrayItem("camp_base_dto")]
		public List<CampBaseDto> CampSets
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

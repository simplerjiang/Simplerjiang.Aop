using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignCashListQueryResponse : AopResponse
	{
		[XmlArray("camp_list")]
		[XmlArrayItem("cash_campaign_info")]
		public List<CashCampaignInfo> CampList
		{
			get;
			set;
		}

		[XmlElement("page_index")]
		public string PageIndex
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public string PageSize
		{
			get;
			set;
		}

		[XmlElement("total_size")]
		public string TotalSize
		{
			get;
			set;
		}
	}
}

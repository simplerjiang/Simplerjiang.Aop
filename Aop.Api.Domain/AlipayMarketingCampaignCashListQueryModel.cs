using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignCashListQueryModel : AopObject
	{
		[XmlElement("camp_status")]
		public string CampStatus
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
	}
}

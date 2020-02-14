using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignCrowdBatchqueryModel : AopObject
	{
		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("page_number")]
		public string PageNumber
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

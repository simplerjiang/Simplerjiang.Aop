using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignIntelligentPromoBatchqueryModel : AopObject
	{
		[XmlElement("operator_context")]
		public PromoOperatorInfo OperatorContext
		{
			get;
			set;
		}

		[XmlElement("out_request_no")]
		public string OutRequestNo
		{
			get;
			set;
		}

		[XmlElement("owner_info")]
		public PromoOperatorInfo OwnerInfo
		{
			get;
			set;
		}

		[XmlElement("page_info")]
		public PromoPageInfo PageInfo
		{
			get;
			set;
		}
	}
}

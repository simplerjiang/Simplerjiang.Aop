using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankMarketingCampaignPrizeListQueryResponse : AopResponse
	{
		[XmlArray("prize_list")]
		[XmlArrayItem("prize_model")]
		public List<PrizeModel> PrizeList
		{
			get;
			set;
		}

		[XmlElement("total_size")]
		public long TotalSize
		{
			get;
			set;
		}
	}
}

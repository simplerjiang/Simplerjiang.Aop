using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiServindustryPortfolioShopBatchqueryResponse : AopResponse
	{
		[XmlElement("portfolio_count")]
		public long PortfolioCount
		{
			get;
			set;
		}

		[XmlArray("portfolio_info_list")]
		[XmlArrayItem("portfolio_info_open_model")]
		public List<PortfolioInfoOpenModel> PortfolioInfoList
		{
			get;
			set;
		}
	}
}

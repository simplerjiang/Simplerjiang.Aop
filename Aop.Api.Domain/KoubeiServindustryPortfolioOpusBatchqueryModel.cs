using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiServindustryPortfolioOpusBatchqueryModel : AopObject
	{
		[XmlElement("commodity_id")]
		public string CommodityId
		{
			get;
			set;
		}

		[XmlElement("page_no")]
		public long PageNo
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}

		[XmlElement("portfolio_id")]
		public string PortfolioId
		{
			get;
			set;
		}
	}
}

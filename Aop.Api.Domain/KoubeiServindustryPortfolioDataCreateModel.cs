using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiServindustryPortfolioDataCreateModel : AopObject
	{
		[XmlElement("commodity_id")]
		public string CommodityId
		{
			get;
			set;
		}

		[XmlElement("cover_media_id")]
		public string CoverMediaId
		{
			get;
			set;
		}

		[XmlElement("cover_media_type")]
		public string CoverMediaType
		{
			get;
			set;
		}

		[XmlElement("external_portfolio_id")]
		public string ExternalPortfolioId
		{
			get;
			set;
		}

		[XmlElement("portfolio_operator_info")]
		public PortfolioOperatorInfo PortfolioOperatorInfo
		{
			get;
			set;
		}

		[XmlArray("portfolio_shops")]
		[XmlArrayItem("portfolio_shop")]
		public List<PortfolioShop> PortfolioShops
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}
	}
}

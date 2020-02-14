using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiServindustryPortfolioDataModifyModel : AopObject
	{
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

		[XmlElement("portfolio_id")]
		public string PortfolioId
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

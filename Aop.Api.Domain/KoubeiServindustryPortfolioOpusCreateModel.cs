using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiServindustryPortfolioOpusCreateModel : AopObject
	{
		[XmlElement("commodity_id")]
		public string CommodityId
		{
			get;
			set;
		}

		[XmlArray("opuses")]
		[XmlArrayItem("opus_info")]
		public List<OpusInfo> Opuses
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
	}
}

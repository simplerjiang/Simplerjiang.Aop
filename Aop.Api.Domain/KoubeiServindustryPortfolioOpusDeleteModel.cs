using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiServindustryPortfolioOpusDeleteModel : AopObject
	{
		[XmlArray("opus_ids")]
		[XmlArrayItem("string")]
		public List<string> OpusIds
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

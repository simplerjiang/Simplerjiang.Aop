using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiServindustryPortfolioDataDeleteModel : AopObject
	{
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

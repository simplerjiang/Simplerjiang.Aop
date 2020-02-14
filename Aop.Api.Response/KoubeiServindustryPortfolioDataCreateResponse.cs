using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiServindustryPortfolioDataCreateResponse : AopResponse
	{
		[XmlElement("portfolio_id")]
		public string PortfolioId
		{
			get;
			set;
		}
	}
}

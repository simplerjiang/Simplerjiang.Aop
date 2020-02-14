using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiServindustryPortfolioOpusCreateResponse : AopResponse
	{
		[XmlElement("opuses")]
		public OpusCreateResponse Opuses
		{
			get;
			set;
		}
	}
}

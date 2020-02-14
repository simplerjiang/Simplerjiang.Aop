using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingToolFengdieSitesQueryResponse : AopResponse
	{
		[XmlElement("data")]
		public FengdieSitesQueryRespModel Data
		{
			get;
			set;
		}
	}
}

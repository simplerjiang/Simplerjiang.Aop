using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingToolFengdieActivityQueryResponse : AopResponse
	{
		[XmlElement("activity")]
		public FengdieActivity Activity
		{
			get;
			set;
		}
	}
}

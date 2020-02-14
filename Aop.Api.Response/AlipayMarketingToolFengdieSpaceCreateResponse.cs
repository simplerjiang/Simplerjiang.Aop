using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingToolFengdieSpaceCreateResponse : AopResponse
	{
		[XmlElement("data")]
		public FengdieSpaceDetailModel Data
		{
			get;
			set;
		}
	}
}

using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingToolFengdieMemberCreateResponse : AopResponse
	{
		[XmlElement("data")]
		public FengdieSpaceMemberCreateModel Data
		{
			get;
			set;
		}
	}
}

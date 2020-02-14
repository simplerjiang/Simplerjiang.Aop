using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicGroupCrowdQueryResponse : AopResponse
	{
		[XmlElement("count")]
		public string Count
		{
			get;
			set;
		}
	}
}

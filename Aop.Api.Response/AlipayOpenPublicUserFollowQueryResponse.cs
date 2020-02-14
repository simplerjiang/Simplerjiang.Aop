using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicUserFollowQueryResponse : AopResponse
	{
		[XmlElement("is_follow")]
		public string IsFollow
		{
			get;
			set;
		}
	}
}

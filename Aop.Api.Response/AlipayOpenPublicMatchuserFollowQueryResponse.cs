using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicMatchuserFollowQueryResponse : AopResponse
	{
		[XmlElement("is_follow")]
		public string IsFollow
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}

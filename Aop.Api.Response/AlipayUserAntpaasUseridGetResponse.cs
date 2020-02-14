using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAntpaasUseridGetResponse : AopResponse
	{
		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}

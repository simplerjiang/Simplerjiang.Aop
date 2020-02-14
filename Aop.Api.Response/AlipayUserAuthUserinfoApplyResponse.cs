using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAuthUserinfoApplyResponse : AopResponse
	{
		[XmlElement("auth_code")]
		public string AuthCode
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

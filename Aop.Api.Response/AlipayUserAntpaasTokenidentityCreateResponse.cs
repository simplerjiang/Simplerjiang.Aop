using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAntpaasTokenidentityCreateResponse : AopResponse
	{
		[XmlElement("ant_id")]
		public string AntId
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

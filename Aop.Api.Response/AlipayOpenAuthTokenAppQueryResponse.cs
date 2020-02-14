using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAuthTokenAppQueryResponse : AopResponse
	{
		[XmlElement("auth_app_id")]
		public string AuthAppId
		{
			get;
			set;
		}

		[XmlElement("auth_end")]
		public string AuthEnd
		{
			get;
			set;
		}

		[XmlArray("auth_methods")]
		[XmlArrayItem("string")]
		public List<string> AuthMethods
		{
			get;
			set;
		}

		[XmlElement("auth_start")]
		public string AuthStart
		{
			get;
			set;
		}

		[XmlElement("expires_in")]
		public long ExpiresIn
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
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

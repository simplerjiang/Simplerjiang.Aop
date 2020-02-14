using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAuthTokenAppModel : AopObject
	{
		[XmlElement("code")]
		public string Code
		{
			get;
			set;
		}

		[XmlElement("grant_type")]
		public string GrantType
		{
			get;
			set;
		}

		[XmlElement("refresh_token")]
		public string RefreshToken
		{
			get;
			set;
		}
	}
}

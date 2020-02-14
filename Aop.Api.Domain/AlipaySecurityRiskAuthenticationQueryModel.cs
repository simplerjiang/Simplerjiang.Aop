using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskAuthenticationQueryModel : AopObject
	{
		[XmlElement("authentication_scene")]
		public AuthenticationScene AuthenticationScene
		{
			get;
			set;
		}

		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("biz_info")]
		public string BizInfo
		{
			get;
			set;
		}

		[XmlElement("token_id")]
		public string TokenId
		{
			get;
			set;
		}
	}
}

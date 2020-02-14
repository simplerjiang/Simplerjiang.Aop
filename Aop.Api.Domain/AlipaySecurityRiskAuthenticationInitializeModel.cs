using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskAuthenticationInitializeModel : AopObject
	{
		[XmlElement("authentication_info")]
		public AuthenticationInfo AuthenticationInfo
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

		[XmlElement("env_info")]
		public string EnvInfo
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AuthenticationInfo : AopObject
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

		[XmlElement("extend_info")]
		public string ExtendInfo
		{
			get;
			set;
		}

		[XmlElement("principal_info")]
		public PrincipalInfo PrincipalInfo
		{
			get;
			set;
		}
	}
}

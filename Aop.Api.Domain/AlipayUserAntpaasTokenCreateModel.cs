using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserAntpaasTokenCreateModel : AopObject
	{
		[XmlElement("bind_mobile")]
		public string BindMobile
		{
			get;
			set;
		}

		[XmlElement("country")]
		public string Country
		{
			get;
			set;
		}

		[XmlElement("login_password")]
		public string LoginPassword
		{
			get;
			set;
		}

		[XmlElement("logon_id")]
		public string LogonId
		{
			get;
			set;
		}

		[XmlElement("need_supply")]
		public bool NeedSupply
		{
			get;
			set;
		}

		[XmlElement("security_password")]
		public string SecurityPassword
		{
			get;
			set;
		}

		[XmlElement("source")]
		public string Source
		{
			get;
			set;
		}

		[XmlElement("user_type")]
		public string UserType
		{
			get;
			set;
		}
	}
}

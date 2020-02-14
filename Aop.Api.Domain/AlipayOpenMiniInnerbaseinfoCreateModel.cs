using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenMiniInnerbaseinfoCreateModel : AopObject
	{
		[XmlElement("app_alias_name")]
		public string AppAliasName
		{
			get;
			set;
		}

		[XmlElement("app_desc")]
		public string AppDesc
		{
			get;
			set;
		}

		[XmlElement("app_logo")]
		public string AppLogo
		{
			get;
			set;
		}

		[XmlElement("app_slogan")]
		public string AppSlogan
		{
			get;
			set;
		}

		[XmlElement("client_type")]
		public string ClientType
		{
			get;
			set;
		}

		[XmlElement("pid")]
		public string Pid
		{
			get;
			set;
		}
	}
}

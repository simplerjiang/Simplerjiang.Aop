using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicQrcodeCreateModel : AopObject
	{
		[XmlElement("code_info")]
		public CodeInfo CodeInfo
		{
			get;
			set;
		}

		[XmlElement("code_type")]
		public string CodeType
		{
			get;
			set;
		}

		[XmlElement("expire_second")]
		public string ExpireSecond
		{
			get;
			set;
		}

		[XmlElement("show_logo")]
		public string ShowLogo
		{
			get;
			set;
		}
	}
}

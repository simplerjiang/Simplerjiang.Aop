using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityDataDatabusSendModel : AopObject
	{
		[XmlElement("security_content")]
		public string SecurityContent
		{
			get;
			set;
		}

		[XmlElement("security_sign")]
		public string SecuritySign
		{
			get;
			set;
		}
	}
}

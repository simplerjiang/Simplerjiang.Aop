using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicMessageSingleSendModel : AopObject
	{
		[XmlElement("template")]
		public Template Template
		{
			get;
			set;
		}

		[XmlElement("to_user_id")]
		public string ToUserId
		{
			get;
			set;
		}
	}
}

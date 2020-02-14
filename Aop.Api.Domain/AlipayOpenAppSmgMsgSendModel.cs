using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAppSmgMsgSendModel : AopObject
	{
		[XmlElement("numberone")]
		public string Numberone
		{
			get;
			set;
		}

		[XmlElement("numbertowe")]
		public string Numbertowe
		{
			get;
			set;
		}
	}
}

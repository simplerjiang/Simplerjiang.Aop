using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicContentCancelModel : AopObject
	{
		[XmlElement("message_id")]
		public string MessageId
		{
			get;
			set;
		}
	}
}

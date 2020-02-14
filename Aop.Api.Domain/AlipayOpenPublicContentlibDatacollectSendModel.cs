using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicContentlibDatacollectSendModel : AopObject
	{
		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}
	}
}

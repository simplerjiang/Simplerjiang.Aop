using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicMessageQueryModel : AopObject
	{
		[XmlArray("message_ids")]
		[XmlArrayItem("string")]
		public List<string> MessageIds
		{
			get;
			set;
		}
	}
}

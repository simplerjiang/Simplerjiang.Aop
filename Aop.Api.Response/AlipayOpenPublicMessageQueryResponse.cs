using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicMessageQueryResponse : AopResponse
	{
		[XmlArray("list")]
		[XmlArrayItem("public_message_info")]
		public List<PublicMessageInfo> List
		{
			get;
			set;
		}
	}
}

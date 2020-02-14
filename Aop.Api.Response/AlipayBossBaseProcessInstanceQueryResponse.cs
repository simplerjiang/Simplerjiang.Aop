using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayBossBaseProcessInstanceQueryResponse : AopResponse
	{
		[XmlElement("instance")]
		public BPOpenApiInstance Instance
		{
			get;
			set;
		}
	}
}

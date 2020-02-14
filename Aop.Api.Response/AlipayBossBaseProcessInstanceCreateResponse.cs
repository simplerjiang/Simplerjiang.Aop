using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayBossBaseProcessInstanceCreateResponse : AopResponse
	{
		[XmlElement("instance")]
		public BPOpenApiInstance Instance
		{
			get;
			set;
		}
	}
}

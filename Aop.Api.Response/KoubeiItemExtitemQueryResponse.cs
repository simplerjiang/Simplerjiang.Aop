using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiItemExtitemQueryResponse : AopResponse
	{
		[XmlElement("extitem")]
		public ExtItem Extitem
		{
			get;
			set;
		}
	}
}

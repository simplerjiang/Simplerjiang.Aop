using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsCooperationProductQueryResponse : AopResponse
	{
		[XmlElement("product")]
		public InsProduct Product
		{
			get;
			set;
		}
	}
}

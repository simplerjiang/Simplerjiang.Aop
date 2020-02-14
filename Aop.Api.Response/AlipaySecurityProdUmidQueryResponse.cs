using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdUmidQueryResponse : AopResponse
	{
		[XmlElement("umid")]
		public string Umid
		{
			get;
			set;
		}
	}
}

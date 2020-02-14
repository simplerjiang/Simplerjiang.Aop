using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicXwbtestabcdBatchqueryResponse : AopResponse
	{
		[XmlElement("b")]
		public string B
		{
			get;
			set;
		}
	}
}

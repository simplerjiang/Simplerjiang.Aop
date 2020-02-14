using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdXwbtestprodQueryResponse : AopResponse
	{
		[XmlElement("out_a")]
		public string OutA
		{
			get;
			set;
		}

		[XmlElement("out_b")]
		public long OutB
		{
			get;
			set;
		}
	}
}

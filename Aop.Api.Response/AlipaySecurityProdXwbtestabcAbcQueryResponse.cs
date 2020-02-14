using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdXwbtestabcAbcQueryResponse : AopResponse
	{
		[XmlElement("xwb")]
		public string Xwb
		{
			get;
			set;
		}
	}
}

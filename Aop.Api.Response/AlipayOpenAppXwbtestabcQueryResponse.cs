using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAppXwbtestabcQueryResponse : AopResponse
	{
		[XmlElement("xw")]
		public string Xw
		{
			get;
			set;
		}
	}
}

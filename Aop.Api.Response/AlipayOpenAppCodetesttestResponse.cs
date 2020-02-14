using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAppCodetesttestResponse : AopResponse
	{
		[XmlElement("testtesttest")]
		public string Testtesttest
		{
			get;
			set;
		}
	}
}

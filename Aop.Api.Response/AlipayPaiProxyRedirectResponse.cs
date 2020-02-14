using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPaiProxyRedirectResponse : AopResponse
	{
		[XmlElement("test_res")]
		public string TestRes
		{
			get;
			set;
		}
	}
}

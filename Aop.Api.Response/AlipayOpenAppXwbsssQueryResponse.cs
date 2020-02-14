using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAppXwbsssQueryResponse : AopResponse
	{
		[XmlElement("a")]
		public string A
		{
			get;
			set;
		}
	}
}

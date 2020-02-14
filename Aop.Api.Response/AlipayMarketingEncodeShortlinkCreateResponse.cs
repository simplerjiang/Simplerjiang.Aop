using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingEncodeShortlinkCreateResponse : AopResponse
	{
		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}
	}
}

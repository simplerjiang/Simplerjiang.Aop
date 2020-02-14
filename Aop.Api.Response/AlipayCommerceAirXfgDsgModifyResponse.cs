using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceAirXfgDsgModifyResponse : AopResponse
	{
		[XmlElement("level")]
		public string Level
		{
			get;
			set;
		}
	}
}

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicShortlinkCreateResponse : AopResponse
	{
		[XmlElement("shortlink")]
		public string Shortlink
		{
			get;
			set;
		}
	}
}

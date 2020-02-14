using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPlatformUseridGetResponse : AopResponse
	{
		[XmlElement("dict")]
		public string Dict
		{
			get;
			set;
		}
	}
}

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobileUrlDeviceverifyAddResponse : AopResponse
	{
		[XmlElement("response")]
		public bool Response
		{
			get;
			set;
		}
	}
}

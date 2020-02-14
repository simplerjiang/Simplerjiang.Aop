using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarMaintainDataUpdateResponse : AopResponse
	{
		[XmlElement("info")]
		public string Info
		{
			get;
			set;
		}
	}
}

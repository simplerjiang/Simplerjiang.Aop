using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOverseasTravelContentCreateResponse : AopResponse
	{
		[XmlElement("result_msg")]
		public string ResultMsg
		{
			get;
			set;
		}
	}
}

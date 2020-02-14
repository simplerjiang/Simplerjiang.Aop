using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOverseasTravelContentCancelResponse : AopResponse
	{
		[XmlElement("result_msg")]
		public string ResultMsg
		{
			get;
			set;
		}
	}
}

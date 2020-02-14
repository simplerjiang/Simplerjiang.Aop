using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarMaintainOrderCreateResponse : AopResponse
	{
		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}
	}
}

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCardDeleteResponse : AopResponse
	{
		[XmlElement("biz_serial_no")]
		public string BizSerialNo
		{
			get;
			set;
		}
	}
}

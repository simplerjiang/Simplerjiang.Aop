using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPointOrderAddResponse : AopResponse
	{
		[XmlElement("alipay_order_no")]
		public string AlipayOrderNo
		{
			get;
			set;
		}

		[XmlElement("result_code")]
		public bool ResultCode
		{
			get;
			set;
		}
	}
}

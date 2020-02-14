using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMicropayOrderGetResponse : AopResponse
	{
		[XmlElement("micro_pay_order_detail")]
		public MicroPayOrderDetail MicroPayOrderDetail
		{
			get;
			set;
		}
	}
}

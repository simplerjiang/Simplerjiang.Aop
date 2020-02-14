using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaMerchantOrderCreditModifyResponse : AopResponse
	{
		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}

		[XmlElement("overdue_time")]
		public string OverdueTime
		{
			get;
			set;
		}

		[XmlElement("zm_order_no")]
		public string ZmOrderNo
		{
			get;
			set;
		}
	}
}

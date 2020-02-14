using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaMerchantOrderCreditModifyModel : AopObject
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

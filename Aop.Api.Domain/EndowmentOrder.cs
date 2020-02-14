using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class EndowmentOrder : AopObject
	{
		[XmlElement("apply_amount")]
		public string ApplyAmount
		{
			get;
			set;
		}

		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlElement("pay_time")]
		public string PayTime
		{
			get;
			set;
		}

		[XmlElement("ta_request_id")]
		public string TaRequestId
		{
			get;
			set;
		}
	}
}

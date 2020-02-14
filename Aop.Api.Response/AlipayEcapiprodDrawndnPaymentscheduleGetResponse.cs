using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcapiprodDrawndnPaymentscheduleGetResponse : AopResponse
	{
		[XmlArray("payment_schedules")]
		[XmlArrayItem("payment_schedule")]
		public List<PaymentSchedule> PaymentSchedules
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}
	}
}

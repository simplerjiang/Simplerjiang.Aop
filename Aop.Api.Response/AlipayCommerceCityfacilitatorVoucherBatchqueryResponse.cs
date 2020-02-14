using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceCityfacilitatorVoucherBatchqueryResponse : AopResponse
	{
		[XmlArray("tickets")]
		[XmlArrayItem("ticket_detail_info")]
		public List<TicketDetailInfo> Tickets
		{
			get;
			set;
		}
	}
}

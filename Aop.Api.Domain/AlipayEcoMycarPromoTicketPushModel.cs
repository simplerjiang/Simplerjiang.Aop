using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarPromoTicketPushModel : AopObject
	{
		[XmlElement("apply_no")]
		public string ApplyNo
		{
			get;
			set;
		}

		[XmlElement("apply_status")]
		public string ApplyStatus
		{
			get;
			set;
		}

		[XmlElement("code_no")]
		public string CodeNo
		{
			get;
			set;
		}

		[XmlElement("ticket_id")]
		public string TicketId
		{
			get;
			set;
		}
	}
}

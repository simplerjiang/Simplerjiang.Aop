using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TicketTransInfo : AopObject
	{
		[XmlElement("create_time")]
		public string CreateTime
		{
			get;
			set;
		}

		[XmlElement("last_modify_time")]
		public string LastModifyTime
		{
			get;
			set;
		}

		[XmlElement("ticket_trans_id")]
		public string TicketTransId
		{
			get;
			set;
		}

		[XmlElement("ticket_trans_type")]
		public string TicketTransType
		{
			get;
			set;
		}
	}
}

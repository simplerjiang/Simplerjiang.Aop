using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CodeNOList : AopObject
	{
		[XmlElement("amount")]
		public string Amount
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

		[XmlElement("sub_type")]
		public string SubType
		{
			get;
			set;
		}

		[XmlElement("ticket_type")]
		public string TicketType
		{
			get;
			set;
		}

		[XmlElement("valid_date")]
		public string ValidDate
		{
			get;
			set;
		}
	}
}

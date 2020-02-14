using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SendRule : AopObject
	{
		[XmlElement("allow_repeat_send")]
		public string AllowRepeatSend
		{
			get;
			set;
		}

		[XmlElement("min_cost")]
		public string MinCost
		{
			get;
			set;
		}

		[XmlElement("send_budget")]
		public string SendBudget
		{
			get;
			set;
		}

		[XmlElement("send_num")]
		public string SendNum
		{
			get;
			set;
		}
	}
}

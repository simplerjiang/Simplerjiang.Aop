using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class EduOneCardDepositCardQueryResult : AopObject
	{
		[XmlElement("agent_code")]
		public string AgentCode
		{
			get;
			set;
		}

		[XmlElement("agent_name")]
		public string AgentName
		{
			get;
			set;
		}

		[XmlElement("balance")]
		public string Balance
		{
			get;
			set;
		}

		[XmlElement("card_name")]
		public string CardName
		{
			get;
			set;
		}

		[XmlElement("card_no")]
		public string CardNo
		{
			get;
			set;
		}

		[XmlElement("last_update_time")]
		public string LastUpdateTime
		{
			get;
			set;
		}

		[XmlElement("pound_amount")]
		public string PoundAmount
		{
			get;
			set;
		}
	}
}

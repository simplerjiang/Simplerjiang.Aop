using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayBossCsChannelQueryResponse : AopResponse
	{
		[XmlElement("att")]
		public string Att
		{
			get;
			set;
		}

		[XmlElement("comment")]
		public string Comment
		{
			get;
			set;
		}

		[XmlElement("connection_rate")]
		public string ConnectionRate
		{
			get;
			set;
		}

		[XmlElement("curr_agent_talking")]
		public string CurrAgentTalking
		{
			get;
			set;
		}

		[XmlElement("curr_agents_logged_in")]
		public string CurrAgentsLoggedIn
		{
			get;
			set;
		}

		[XmlElement("curr_number_waiting_calls")]
		public string CurrNumberWaitingCalls
		{
			get;
			set;
		}

		[XmlElement("current_not_ready_agents")]
		public string CurrentNotReadyAgents
		{
			get;
			set;
		}

		[XmlElement("current_ready_agents")]
		public string CurrentReadyAgents
		{
			get;
			set;
		}

		[XmlElement("row_key")]
		public string RowKey
		{
			get;
			set;
		}

		[XmlElement("visitor_inflow")]
		public string VisitorInflow
		{
			get;
			set;
		}

		[XmlElement("visitor_response")]
		public string VisitorResponse
		{
			get;
			set;
		}

		[XmlElement("visitor_response_transfer")]
		public string VisitorResponseTransfer
		{
			get;
			set;
		}
	}
}

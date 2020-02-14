using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAgentOrderQueryResponse : AopResponse
	{
		[XmlElement("agent_app_id")]
		public string AgentAppId
		{
			get;
			set;
		}

		[XmlElement("confirm_url")]
		public string ConfirmUrl
		{
			get;
			set;
		}

		[XmlElement("merchant_pid")]
		public string MerchantPid
		{
			get;
			set;
		}

		[XmlElement("order_status")]
		public string OrderStatus
		{
			get;
			set;
		}

		[XmlElement("reject_reason")]
		public string RejectReason
		{
			get;
			set;
		}
	}
}

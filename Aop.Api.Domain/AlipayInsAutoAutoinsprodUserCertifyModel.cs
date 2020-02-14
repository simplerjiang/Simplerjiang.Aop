using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsAutoAutoinsprodUserCertifyModel : AopObject
	{
		[XmlElement("agent_id_card_name")]
		public string AgentIdCardName
		{
			get;
			set;
		}

		[XmlElement("agent_id_card_no")]
		public string AgentIdCardNo
		{
			get;
			set;
		}

		[XmlElement("agent_user_id")]
		public string AgentUserId
		{
			get;
			set;
		}
	}
}

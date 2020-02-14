using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsCooperationProductQrcodeApplyModel : AopObject
	{
		[XmlElement("agent_id")]
		public string AgentId
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

		[XmlElement("agent_phone")]
		public string AgentPhone
		{
			get;
			set;
		}

		[XmlElement("inst_id")]
		public string InstId
		{
			get;
			set;
		}

		[XmlElement("prod_code")]
		public string ProdCode
		{
			get;
			set;
		}
	}
}

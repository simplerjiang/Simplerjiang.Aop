using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsCooperationRegionQrcodeApplyModel : AopObject
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

		[XmlArray("prod_code_list")]
		[XmlArrayItem("string")]
		public List<string> ProdCodeList
		{
			get;
			set;
		}

		[XmlElement("region_id")]
		public string RegionId
		{
			get;
			set;
		}

		[XmlElement("region_name")]
		public string RegionName
		{
			get;
			set;
		}
	}
}

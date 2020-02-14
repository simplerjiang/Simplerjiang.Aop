using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsScenePolicyEndorseApplyModel : AopObject
	{
		[XmlArray("endorse_items")]
		[XmlArrayItem("ins_endorse_item")]
		public List<InsEndorseItem> EndorseItems
		{
			get;
			set;
		}

		[XmlElement("out_request_no")]
		public string OutRequestNo
		{
			get;
			set;
		}

		[XmlElement("policy_no")]
		public string PolicyNo
		{
			get;
			set;
		}

		[XmlElement("source")]
		public string Source
		{
			get;
			set;
		}
	}
}

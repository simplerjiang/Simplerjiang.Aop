using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAgentSignstatusQueryModel : AopObject
	{
		[XmlElement("pid")]
		public string Pid
		{
			get;
			set;
		}

		[XmlArray("product_codes")]
		[XmlArrayItem("string")]
		public List<string> ProductCodes
		{
			get;
			set;
		}
	}
}

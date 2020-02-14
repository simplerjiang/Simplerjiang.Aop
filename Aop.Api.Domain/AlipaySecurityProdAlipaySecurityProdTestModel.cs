using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdAlipaySecurityProdTestModel : AopObject
	{
		[XmlArray("cds")]
		[XmlArrayItem("string")]
		public List<string> Cds
		{
			get;
			set;
		}

		[XmlElement("ddd")]
		public string Ddd
		{
			get;
			set;
		}
	}
}

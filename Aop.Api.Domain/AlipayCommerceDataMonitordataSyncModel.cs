using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceDataMonitordataSyncModel : AopObject
	{
		[XmlArray("datas")]
		[XmlArrayItem("datas")]
		public List<Datas> Datas
		{
			get;
			set;
		}

		[XmlElement("interface_version")]
		public string InterfaceVersion
		{
			get;
			set;
		}

		[XmlElement("product_code")]
		public string ProductCode
		{
			get;
			set;
		}
	}
}

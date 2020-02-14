using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdXwbtestprodQueryModel : AopObject
	{
		[XmlElement("in_a")]
		public string InA
		{
			get;
			set;
		}

		[XmlElement("province_code")]
		public string ProvinceCode
		{
			get;
			set;
		}

		[XmlElement("qwe_dfgfd")]
		public string QweDfgfd
		{
			get;
			set;
		}
	}
}

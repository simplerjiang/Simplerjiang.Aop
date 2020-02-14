using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsUnderwritePolicyQueryModel : AopObject
	{
		[XmlElement("out_biz_no")]
		public string OutBizNo
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

		[XmlElement("prod_code")]
		public string ProdCode
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdFingerprintApplyModel : AopObject
	{
		[XmlElement("ifaa_version")]
		public string IfaaVersion
		{
			get;
			set;
		}

		[XmlElement("ifaf_message")]
		public string IfafMessage
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("sec_data")]
		public string SecData
		{
			get;
			set;
		}
	}
}

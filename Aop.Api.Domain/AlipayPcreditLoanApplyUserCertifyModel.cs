using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayPcreditLoanApplyUserCertifyModel : AopObject
	{
		[XmlElement("apply_no")]
		public string ApplyNo
		{
			get;
			set;
		}

		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("cert_type")]
		public string CertType
		{
			get;
			set;
		}

		[XmlElement("user_name")]
		public string UserName
		{
			get;
			set;
		}
	}
}

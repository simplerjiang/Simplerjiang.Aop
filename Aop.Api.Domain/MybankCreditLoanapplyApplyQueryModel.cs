using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditLoanapplyApplyQueryModel : AopObject
	{
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

		[XmlElement("ext_params")]
		public string ExtParams
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("subapply_no")]
		public string SubapplyNo
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserAgreementSignConfirmModel : AopObject
	{
		[XmlElement("apply_token")]
		public string ApplyToken
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

		[XmlElement("confirm_no")]
		public string ConfirmNo
		{
			get;
			set;
		}
	}
}

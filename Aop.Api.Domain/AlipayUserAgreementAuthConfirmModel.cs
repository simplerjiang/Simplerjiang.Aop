using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserAgreementAuthConfirmModel : AopObject
	{
		[XmlElement("agreement_no")]
		public string AgreementNo
		{
			get;
			set;
		}

		[XmlElement("apply_token")]
		public string ApplyToken
		{
			get;
			set;
		}

		[XmlElement("auth_confirm_no")]
		public string AuthConfirmNo
		{
			get;
			set;
		}
	}
}

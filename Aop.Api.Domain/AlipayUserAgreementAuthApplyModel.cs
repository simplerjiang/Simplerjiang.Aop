using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserAgreementAuthApplyModel : AopObject
	{
		[XmlElement("agreement_no")]
		public string AgreementNo
		{
			get;
			set;
		}

		[XmlElement("auth_confirm_type")]
		public string AuthConfirmType
		{
			get;
			set;
		}

		[XmlElement("auth_scene")]
		public string AuthScene
		{
			get;
			set;
		}
	}
}

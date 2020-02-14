using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicAccountDeleteModel : AopObject
	{
		[XmlElement("agreement_id")]
		public string AgreementId
		{
			get;
			set;
		}

		[XmlElement("bind_account_no")]
		public string BindAccountNo
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicPartnerMenuOperateModel : AopObject
	{
		[XmlElement("action_param")]
		public string ActionParam
		{
			get;
			set;
		}

		[XmlElement("action_type")]
		public string ActionType
		{
			get;
			set;
		}

		[XmlElement("agreement_id")]
		public string AgreementId
		{
			get;
			set;
		}

		[XmlElement("public_id")]
		public string PublicId
		{
			get;
			set;
		}

		[XmlElement("third_account_id")]
		public string ThirdAccountId
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}

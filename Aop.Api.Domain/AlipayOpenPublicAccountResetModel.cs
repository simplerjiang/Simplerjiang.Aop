using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicAccountResetModel : AopObject
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

		[XmlElement("display_name")]
		public string DisplayName
		{
			get;
			set;
		}

		[XmlElement("from_user_id")]
		public string FromUserId
		{
			get;
			set;
		}

		[XmlElement("real_name")]
		public string RealName
		{
			get;
			set;
		}

		[XmlElement("remark")]
		public string Remark
		{
			get;
			set;
		}
	}
}

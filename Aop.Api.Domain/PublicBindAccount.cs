using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PublicBindAccount : AopObject
	{
		[XmlElement("agreement_id")]
		public string AgreementId
		{
			get;
			set;
		}

		[XmlElement("app_id")]
		public string AppId
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
	}
}

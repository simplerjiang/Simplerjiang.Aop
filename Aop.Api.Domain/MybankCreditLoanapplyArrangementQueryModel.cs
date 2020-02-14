using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditLoanapplyArrangementQueryModel : AopObject
	{
		[XmlElement("ar_pd_code")]
		public string ArPdCode
		{
			get;
			set;
		}

		[XmlElement("ip_id")]
		public string IpId
		{
			get;
			set;
		}

		[XmlElement("ip_role_id")]
		public string IpRoleId
		{
			get;
			set;
		}

		[XmlElement("site")]
		public string Site
		{
			get;
			set;
		}

		[XmlElement("site_user_id")]
		public string SiteUserId
		{
			get;
			set;
		}
	}
}

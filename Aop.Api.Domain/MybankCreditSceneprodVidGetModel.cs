using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditSceneprodVidGetModel : AopObject
	{
		[XmlElement("alipay_version")]
		public string AlipayVersion
		{
			get;
			set;
		}

		[XmlElement("org_code")]
		public string OrgCode
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

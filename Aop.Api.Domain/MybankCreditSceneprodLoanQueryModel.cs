using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditSceneprodLoanQueryModel : AopObject
	{
		[XmlElement("org_code")]
		public string OrgCode
		{
			get;
			set;
		}

		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}

		[XmlElement("product_code")]
		public string ProductCode
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

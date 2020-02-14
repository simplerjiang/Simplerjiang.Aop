using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditSceneprodPlanQueryModel : AopObject
	{
		[XmlElement("channel")]
		public string Channel
		{
			get;
			set;
		}

		[XmlElement("customer_channel")]
		public string CustomerChannel
		{
			get;
			set;
		}

		[XmlElement("ext_param")]
		public string ExtParam
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

		[XmlElement("product_code")]
		public string ProductCode
		{
			get;
			set;
		}

		[XmlElement("scene")]
		public string Scene
		{
			get;
			set;
		}

		[XmlElement("seq_no")]
		public string SeqNo
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

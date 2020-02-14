using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditLoanapplyDataQueryModel : AopObject
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("category")]
		public string Category
		{
			get;
			set;
		}

		[XmlElement("data_version")]
		public string DataVersion
		{
			get;
			set;
		}

		[XmlElement("entity_code")]
		public string EntityCode
		{
			get;
			set;
		}

		[XmlElement("entity_name")]
		public string EntityName
		{
			get;
			set;
		}

		[XmlElement("entity_type")]
		public string EntityType
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
	}
}

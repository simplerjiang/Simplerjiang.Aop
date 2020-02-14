using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditLoantradeLoanschemeQueryModel : AopObject
	{
		[XmlElement("biz")]
		public string Biz
		{
			get;
			set;
		}

		[XmlElement("biz_no")]
		public string BizNo
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

		[XmlElement("loan_policy_code")]
		public string LoanPolicyCode
		{
			get;
			set;
		}

		[XmlElement("out_uni_code")]
		public string OutUniCode
		{
			get;
			set;
		}

		[XmlElement("sale_pd_code")]
		public string SalePdCode
		{
			get;
			set;
		}

		[XmlElement("scen")]
		public string Scen
		{
			get;
			set;
		}
	}
}

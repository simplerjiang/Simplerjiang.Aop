using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditSceneprodLoanModifyModel : AopObject
	{
		[XmlElement("ext_param")]
		public string ExtParam
		{
			get;
			set;
		}

		[XmlElement("ext_param_info")]
		public SceneExtParam ExtParamInfo
		{
			get;
			set;
		}

		[XmlElement("finance_inst_iprole_id")]
		public string FinanceInstIproleId
		{
			get;
			set;
		}

		[XmlElement("loan_amt")]
		public string LoanAmt
		{
			get;
			set;
		}

		[XmlElement("loan_period")]
		public string LoanPeriod
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}

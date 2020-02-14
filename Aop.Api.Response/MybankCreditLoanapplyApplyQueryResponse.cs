using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditLoanapplyApplyQueryResponse : AopResponse
	{
		[XmlElement("apply_amt")]
		public string ApplyAmt
		{
			get;
			set;
		}

		[XmlElement("apply_date")]
		public string ApplyDate
		{
			get;
			set;
		}

		[XmlElement("apply_no")]
		public string ApplyNo
		{
			get;
			set;
		}

		[XmlElement("apply_status")]
		public string ApplyStatus
		{
			get;
			set;
		}

		[XmlElement("approve_conclu")]
		public string ApproveConclu
		{
			get;
			set;
		}

		[XmlElement("approve_credit_result")]
		public ApproveCreditResult ApproveCreditResult
		{
			get;
			set;
		}

		[XmlElement("approve_finish_date")]
		public string ApproveFinishDate
		{
			get;
			set;
		}

		[XmlElement("cust_inst_appid")]
		public string CustInstAppid
		{
			get;
			set;
		}

		[XmlElement("cust_inst_code")]
		public string CustInstCode
		{
			get;
			set;
		}

		[XmlElement("ext_json")]
		public string ExtJson
		{
			get;
			set;
		}

		[XmlArray("investig_category_result")]
		[XmlArrayItem("investig_category_result")]
		public List<InvestigCategoryResult> InvestigCategoryResult
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

		[XmlElement("loan_type")]
		public string LoanType
		{
			get;
			set;
		}

		[XmlElement("op_prod_code")]
		public string OpProdCode
		{
			get;
			set;
		}

		[XmlElement("op_prod_code_version")]
		public string OpProdCodeVersion
		{
			get;
			set;
		}

		[XmlElement("refuse_code")]
		public string RefuseCode
		{
			get;
			set;
		}

		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}

		[XmlElement("state")]
		public string State
		{
			get;
			set;
		}
	}
}

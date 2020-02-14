using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundAuthOperationDetailQueryResponse : AopResponse
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("auth_no")]
		public string AuthNo
		{
			get;
			set;
		}

		[XmlElement("credit_amount")]
		public string CreditAmount
		{
			get;
			set;
		}

		[XmlElement("extra_param")]
		public string ExtraParam
		{
			get;
			set;
		}

		[XmlElement("fund_amount")]
		public string FundAmount
		{
			get;
			set;
		}

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("gmt_trans")]
		public string GmtTrans
		{
			get;
			set;
		}

		[XmlElement("operation_id")]
		public string OperationId
		{
			get;
			set;
		}

		[XmlElement("operation_type")]
		public string OperationType
		{
			get;
			set;
		}

		[XmlElement("order_title")]
		public string OrderTitle
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

		[XmlElement("out_request_no")]
		public string OutRequestNo
		{
			get;
			set;
		}

		[XmlElement("payer_logon_id")]
		public string PayerLogonId
		{
			get;
			set;
		}

		[XmlElement("payer_user_id")]
		public string PayerUserId
		{
			get;
			set;
		}

		[XmlElement("pre_auth_type")]
		public string PreAuthType
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

		[XmlElement("rest_amount")]
		public string RestAmount
		{
			get;
			set;
		}

		[XmlElement("rest_credit_amount")]
		public string RestCreditAmount
		{
			get;
			set;
		}

		[XmlElement("rest_fund_amount")]
		public string RestFundAmount
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

		[XmlElement("total_freeze_amount")]
		public string TotalFreezeAmount
		{
			get;
			set;
		}

		[XmlElement("total_freeze_credit_amount")]
		public string TotalFreezeCreditAmount
		{
			get;
			set;
		}

		[XmlElement("total_freeze_fund_amount")]
		public string TotalFreezeFundAmount
		{
			get;
			set;
		}

		[XmlElement("total_pay_amount")]
		public string TotalPayAmount
		{
			get;
			set;
		}

		[XmlElement("total_pay_credit_amount")]
		public string TotalPayCreditAmount
		{
			get;
			set;
		}

		[XmlElement("total_pay_fund_amount")]
		public string TotalPayFundAmount
		{
			get;
			set;
		}

		[XmlElement("trans_currency")]
		public string TransCurrency
		{
			get;
			set;
		}
	}
}

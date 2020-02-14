using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundAuthOrderFreezeResponse : AopResponse
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

		[XmlElement("fund_amount")]
		public string FundAmount
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

		[XmlElement("status")]
		public string Status
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

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundCouponOperationQueryResponse : AopResponse
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

		[XmlElement("extra_param")]
		public string ExtraParam
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

		[XmlElement("payee_logon_id")]
		public string PayeeLogonId
		{
			get;
			set;
		}

		[XmlElement("payee_user_id")]
		public string PayeeUserId
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

		[XmlElement("remark")]
		public string Remark
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

		[XmlElement("total_pay_refund_amount")]
		public string TotalPayRefundAmount
		{
			get;
			set;
		}
	}
}

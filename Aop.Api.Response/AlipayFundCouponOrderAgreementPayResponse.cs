using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundCouponOrderAgreementPayResponse : AopResponse
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}

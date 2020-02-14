using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundAuthOperationCancelResponse : AopResponse
	{
		[XmlElement("action")]
		public string Action
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
	}
}

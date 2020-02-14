using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaMerchantOrderRentCreateResponse : AopResponse
	{
		[XmlElement("admit_state")]
		public string AdmitState
		{
			get;
			set;
		}

		[XmlElement("invoke_state")]
		public string InvokeState
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}

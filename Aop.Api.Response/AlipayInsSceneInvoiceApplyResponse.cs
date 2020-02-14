using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsSceneInvoiceApplyResponse : AopResponse
	{
		[XmlElement("invoice_apply_no")]
		public string InvoiceApplyNo
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

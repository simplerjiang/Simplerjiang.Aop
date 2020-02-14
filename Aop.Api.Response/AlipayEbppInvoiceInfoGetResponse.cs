using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppInvoiceInfoGetResponse : AopResponse
	{
		[XmlElement("invoice_model")]
		public InvoiceModelContent InvoiceModel
		{
			get;
			set;
		}
	}
}

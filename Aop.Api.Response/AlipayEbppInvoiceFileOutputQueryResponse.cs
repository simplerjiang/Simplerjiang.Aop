using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppInvoiceFileOutputQueryResponse : AopResponse
	{
		[XmlElement("invoice_file_content")]
		public string InvoiceFileContent
		{
			get;
			set;
		}
	}
}

using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppInvoiceTitleDynamicGetResponse : AopResponse
	{
		[XmlElement("title")]
		public InvoiceTitleModel Title
		{
			get;
			set;
		}
	}
}

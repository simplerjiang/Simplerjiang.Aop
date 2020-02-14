using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppInvoiceInfoSendResponse : AopResponse
	{
		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppInvoiceSycnResponse : AopResponse
	{
		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}

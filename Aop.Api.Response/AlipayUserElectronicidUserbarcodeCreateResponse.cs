using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserElectronicidUserbarcodeCreateResponse : AopResponse
	{
		[XmlElement("barcode")]
		public string Barcode
		{
			get;
			set;
		}
	}
}

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarParkingLotbarcodeCreateResponse : AopResponse
	{
		[XmlElement("qrcode_url")]
		public string QrcodeUrl
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

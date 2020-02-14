using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarParkingCardbarcodeCreateResponse : AopResponse
	{
		[XmlArray("qrcodes")]
		[XmlArrayItem("q_rcode")]
		public List<QRcode> Qrcodes
		{
			get;
			set;
		}
	}
}

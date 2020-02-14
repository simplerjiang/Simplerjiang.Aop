using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class QRcode : AopObject
	{
		[XmlElement("card_id")]
		public string CardId
		{
			get;
			set;
		}

		[XmlElement("qrcode_url")]
		public string QrcodeUrl
		{
			get;
			set;
		}
	}
}

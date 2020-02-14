using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CustomsDeclareBuyerInfo : AopObject
	{
		[XmlElement("buyer_cert_no")]
		public string BuyerCertNo
		{
			get;
			set;
		}

		[XmlElement("buyer_name")]
		public string BuyerName
		{
			get;
			set;
		}
	}
}

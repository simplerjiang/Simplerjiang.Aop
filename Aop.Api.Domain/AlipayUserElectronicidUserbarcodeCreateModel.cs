using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserElectronicidUserbarcodeCreateModel : AopObject
	{
		[XmlElement("cert_id")]
		public string CertId
		{
			get;
			set;
		}

		[XmlElement("expire_time")]
		public long ExpireTime
		{
			get;
			set;
		}
	}
}

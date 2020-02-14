using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class VerifyParams : AopObject
	{
		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}
	}
}

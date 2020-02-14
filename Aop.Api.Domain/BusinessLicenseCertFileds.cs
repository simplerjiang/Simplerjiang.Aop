using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BusinessLicenseCertFileds : AopObject
	{
		[XmlElement("creditcode")]
		public string Creditcode
		{
			get;
			set;
		}

		[XmlElement("entname")]
		public string Entname
		{
			get;
			set;
		}
	}
}

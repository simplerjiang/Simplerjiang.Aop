using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserCertDocPassport : AopObject
	{
		[XmlElement("encoded_img")]
		public string EncodedImg
		{
			get;
			set;
		}

		[XmlElement("expire_date")]
		public string ExpireDate
		{
			get;
			set;
		}

		[XmlElement("family_name")]
		public string FamilyName
		{
			get;
			set;
		}

		[XmlElement("given_name")]
		public string GivenName
		{
			get;
			set;
		}

		[XmlElement("number")]
		public string Number
		{
			get;
			set;
		}
	}
}

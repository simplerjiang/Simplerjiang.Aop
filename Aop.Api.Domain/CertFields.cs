using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CertFields : AopObject
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("birth")]
		public string Birth
		{
			get;
			set;
		}

		[XmlElement("certno")]
		public string Certno
		{
			get;
			set;
		}

		[XmlElement("expires")]
		public string Expires
		{
			get;
			set;
		}

		[XmlElement("expiresend")]
		public string Expiresend
		{
			get;
			set;
		}

		[XmlElement("expiresstart")]
		public string Expiresstart
		{
			get;
			set;
		}

		[XmlElement("issuingauthority")]
		public string Issuingauthority
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
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

		[XmlElement("race")]
		public string Race
		{
			get;
			set;
		}

		[XmlElement("renewalnum")]
		public string Renewalnum
		{
			get;
			set;
		}

		[XmlElement("sex")]
		public string Sex
		{
			get;
			set;
		}
	}
}

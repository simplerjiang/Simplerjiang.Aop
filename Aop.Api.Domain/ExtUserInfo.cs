using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ExtUserInfo : AopObject
	{
		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("cert_type")]
		public string CertType
		{
			get;
			set;
		}

		[XmlElement("fix_buyer")]
		public string FixBuyer
		{
			get;
			set;
		}

		[XmlElement("min_age")]
		public string MinAge
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
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

		[XmlElement("need_check_info")]
		public string NeedCheckInfo
		{
			get;
			set;
		}
	}
}

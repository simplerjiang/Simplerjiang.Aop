using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ValidStrategy : AopObject
	{
		[XmlElement("gmt_invalid")]
		public string GmtInvalid
		{
			get;
			set;
		}

		[XmlElement("gmt_sign")]
		public string GmtSign
		{
			get;
			set;
		}

		[XmlElement("gmt_valid")]
		public string GmtValid
		{
			get;
			set;
		}

		[XmlElement("invalid_type")]
		public string InvalidType
		{
			get;
			set;
		}

		[XmlElement("valid_type")]
		public string ValidType
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SecuritydataMobileCity : AopObject
	{
		[XmlElement("city")]
		public string City
		{
			get;
			set;
		}

		[XmlElement("phone_first_7_digits")]
		public string PhoneFirst7Digits
		{
			get;
			set;
		}

		[XmlElement("province")]
		public string Province
		{
			get;
			set;
		}
	}
}

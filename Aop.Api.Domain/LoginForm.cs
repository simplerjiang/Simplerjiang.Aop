using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class LoginForm : AopObject
	{
		[XmlElement("captcha")]
		public string Captcha
		{
			get;
			set;
		}

		[XmlElement("id_card_no")]
		public string IdCardNo
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

		[XmlElement("phone_no")]
		public string PhoneNo
		{
			get;
			set;
		}

		[XmlElement("query_password")]
		public string QueryPassword
		{
			get;
			set;
		}

		[XmlElement("service_password")]
		public string ServicePassword
		{
			get;
			set;
		}

		[XmlElement("sms_code")]
		public string SmsCode
		{
			get;
			set;
		}

		[XmlElement("sms_code_jldx")]
		public string SmsCodeJldx
		{
			get;
			set;
		}
	}
}

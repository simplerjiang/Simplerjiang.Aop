using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAntpaasTestaccountCreateResponse : AopResponse
	{
		[XmlElement("account_level")]
		public string AccountLevel
		{
			get;
			set;
		}

		[XmlElement("cert_name")]
		public string CertName
		{
			get;
			set;
		}

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

		[XmlElement("havana_id")]
		public string HavanaId
		{
			get;
			set;
		}

		[XmlElement("logon_id")]
		public string LogonId
		{
			get;
			set;
		}

		[XmlElement("logon_type")]
		public string LogonType
		{
			get;
			set;
		}

		[XmlElement("message")]
		public string Message
		{
			get;
			set;
		}

		[XmlElement("payment_password")]
		public string PaymentPassword
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

		[XmlElement("success")]
		public string Success
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}

		[XmlElement("user_status")]
		public string UserStatus
		{
			get;
			set;
		}

		[XmlElement("user_type")]
		public string UserType
		{
			get;
			set;
		}
	}
}

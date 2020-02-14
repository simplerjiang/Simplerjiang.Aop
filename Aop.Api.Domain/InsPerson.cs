using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsPerson : AopObject
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("birthday")]
		public string Birthday
		{
			get;
			set;
		}

		[XmlElement("biz_data")]
		public string BizData
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

		[XmlElement("channel_user_id")]
		public string ChannelUserId
		{
			get;
			set;
		}

		[XmlElement("channel_user_source")]
		public string ChannelUserSource
		{
			get;
			set;
		}

		[XmlElement("email")]
		public string Email
		{
			get;
			set;
		}

		[XmlElement("gender")]
		public string Gender
		{
			get;
			set;
		}

		[XmlElement("nationality")]
		public string Nationality
		{
			get;
			set;
		}

		[XmlElement("phone")]
		public string Phone
		{
			get;
			set;
		}

		[XmlElement("pronounce_name")]
		public string PronounceName
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
	}
}

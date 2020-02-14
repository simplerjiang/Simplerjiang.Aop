using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditUserBankcardBindModel : AopObject
	{
		[XmlElement("account_name")]
		public string AccountName
		{
			get;
			set;
		}

		[XmlElement("admin_type")]
		public string AdminType
		{
			get;
			set;
		}

		[XmlElement("admin_user_id")]
		public string AdminUserId
		{
			get;
			set;
		}

		[XmlElement("bankcard_no")]
		public string BankcardNo
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

		[XmlElement("fip_code")]
		public string FipCode
		{
			get;
			set;
		}

		[XmlElement("ip_id")]
		public string IpId
		{
			get;
			set;
		}

		[XmlElement("ip_role_id")]
		public string IpRoleId
		{
			get;
			set;
		}

		[XmlElement("purpose")]
		public string Purpose
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}
	}
}

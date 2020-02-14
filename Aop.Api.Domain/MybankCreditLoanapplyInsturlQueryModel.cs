using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditLoanapplyInsturlQueryModel : AopObject
	{
		[XmlElement("arrangement_no")]
		public string ArrangementNo
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
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

		[XmlElement("cust_group_code")]
		public string CustGroupCode
		{
			get;
			set;
		}

		[XmlElement("ext_business_license_no")]
		public string ExtBusinessLicenseNo
		{
			get;
			set;
		}

		[XmlElement("ext_user_id")]
		public string ExtUserId
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

		[XmlElement("op_pd_code")]
		public string OpPdCode
		{
			get;
			set;
		}

		[XmlElement("url_type")]
		public string UrlType
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

		[XmlElement("user_name")]
		public string UserName
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CPCommServices : AopObject
	{
		[XmlElement("account")]
		public string Account
		{
			get;
			set;
		}

		[XmlElement("account_type")]
		public string AccountType
		{
			get;
			set;
		}

		[XmlElement("audit_desc")]
		public string AuditDesc
		{
			get;
			set;
		}

		[XmlElement("audit_status")]
		public string AuditStatus
		{
			get;
			set;
		}

		[XmlElement("category_name")]
		public string CategoryName
		{
			get;
			set;
		}

		[XmlElement("external_address_scan_result")]
		public string ExternalAddressScanResult
		{
			get;
			set;
		}

		[XmlElement("external_invoke_address")]
		public string ExternalInvokeAddress
		{
			get;
			set;
		}

		[XmlElement("gmt_created")]
		public string GmtCreated
		{
			get;
			set;
		}

		[XmlElement("gmt_modified")]
		public string GmtModified
		{
			get;
			set;
		}

		[XmlElement("next_action")]
		public string NextAction
		{
			get;
			set;
		}

		[XmlElement("qr_code_expires")]
		public string QrCodeExpires
		{
			get;
			set;
		}

		[XmlElement("qr_code_image")]
		public string QrCodeImage
		{
			get;
			set;
		}

		[XmlElement("qr_code_type")]
		public string QrCodeType
		{
			get;
			set;
		}

		[XmlElement("service_expires")]
		public string ServiceExpires
		{
			get;
			set;
		}

		[XmlElement("service_type")]
		public string ServiceType
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}

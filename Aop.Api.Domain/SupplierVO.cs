using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SupplierVO : AopObject
	{
		[XmlElement("biz_status")]
		public string BizStatus
		{
			get;
			set;
		}

		[XmlElement("business_desc")]
		public string BusinessDesc
		{
			get;
			set;
		}

		[XmlElement("certificate_desc")]
		public string CertificateDesc
		{
			get;
			set;
		}

		[XmlElement("short_code")]
		public string ShortCode
		{
			get;
			set;
		}

		[XmlElement("supplier_id")]
		public string SupplierId
		{
			get;
			set;
		}

		[XmlElement("supplier_name")]
		public string SupplierName
		{
			get;
			set;
		}
	}
}

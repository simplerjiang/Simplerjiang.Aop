using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZolozIdentificationCustomerIdcardCertifyModel : AopObject
	{
		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("business_license_cert")]
		public BusinessLicenseCertFileds BusinessLicenseCert
		{
			get;
			set;
		}

		[XmlElement("cert")]
		public CertFields Cert
		{
			get;
			set;
		}

		[XmlElement("idcard_img")]
		public IdCardImg IdcardImg
		{
			get;
			set;
		}

		[XmlElement("operater_id")]
		public string OperaterId
		{
			get;
			set;
		}
	}
}

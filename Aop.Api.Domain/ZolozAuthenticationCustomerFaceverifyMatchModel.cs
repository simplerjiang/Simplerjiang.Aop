using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZolozAuthenticationCustomerFaceverifyMatchModel : AopObject
	{
		[XmlElement("auth_img")]
		public string AuthImg
		{
			get;
			set;
		}

		[XmlElement("auth_img_channel")]
		public string AuthImgChannel
		{
			get;
			set;
		}

		[XmlElement("biz_id")]
		public string BizId
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

		[XmlElement("merchant_uid")]
		public string MerchantUid
		{
			get;
			set;
		}

		[XmlElement("ref_img")]
		public string RefImg
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}

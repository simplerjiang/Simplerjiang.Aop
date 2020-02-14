using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZolozIdentificationCustomerEnrollcertifyInitializeModel : AopObject
	{
		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("biz_scene_name")]
		public string BizSceneName
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

		[XmlElement("face_type")]
		public long FaceType
		{
			get;
			set;
		}

		[XmlElement("has_welcome_page")]
		public bool HasWelcomePage
		{
			get;
			set;
		}

		[XmlElement("metainfo")]
		public string Metainfo
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}

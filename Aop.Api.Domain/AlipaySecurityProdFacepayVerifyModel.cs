using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdFacepayVerifyModel : AopObject
	{
		[XmlElement("check_code")]
		public string CheckCode
		{
			get;
			set;
		}

		[XmlElement("face_image")]
		public string FaceImage
		{
			get;
			set;
		}

		[XmlElement("ftoken")]
		public string Ftoken
		{
			get;
			set;
		}

		[XmlElement("store_id")]
		public string StoreId
		{
			get;
			set;
		}

		[XmlElement("user_auth_id")]
		public string UserAuthId
		{
			get;
			set;
		}

		[XmlElement("user_auth_type")]
		public string UserAuthType
		{
			get;
			set;
		}
	}
}

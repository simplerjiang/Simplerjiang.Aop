using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdFacepayUploadModel : AopObject
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

		[XmlElement("store_id")]
		public string StoreId
		{
			get;
			set;
		}
	}
}

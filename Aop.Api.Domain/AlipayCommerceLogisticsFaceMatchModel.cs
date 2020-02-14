using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceLogisticsFaceMatchModel : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("face_group")]
		public string FaceGroup
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

		[XmlElement("face_rectangle")]
		public string FaceRectangle
		{
			get;
			set;
		}

		[XmlElement("merchant_code")]
		public string MerchantCode
		{
			get;
			set;
		}
	}
}

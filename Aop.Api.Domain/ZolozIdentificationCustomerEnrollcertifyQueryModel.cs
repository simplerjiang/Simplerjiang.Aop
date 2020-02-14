using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZolozIdentificationCustomerEnrollcertifyQueryModel : AopObject
	{
		[XmlElement("biz_id")]
		public string BizId
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

		[XmlElement("zim_id")]
		public string ZimId
		{
			get;
			set;
		}
	}
}

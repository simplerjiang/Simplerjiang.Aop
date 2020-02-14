using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZolozAuthenticationCustomerFtokenQueryModel : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public FaceExtInfo ExtInfo
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
	}
}

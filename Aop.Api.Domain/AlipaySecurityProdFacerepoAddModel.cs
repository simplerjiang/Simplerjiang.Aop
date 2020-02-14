using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdFacerepoAddModel : AopObject
	{
		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("face_str")]
		public string FaceStr
		{
			get;
			set;
		}

		[XmlElement("group_id")]
		public string GroupId
		{
			get;
			set;
		}
	}
}

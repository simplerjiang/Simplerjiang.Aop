using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicShortlinkCreateModel : AopObject
	{
		[XmlElement("remark")]
		public string Remark
		{
			get;
			set;
		}

		[XmlElement("scene_id")]
		public string SceneId
		{
			get;
			set;
		}
	}
}

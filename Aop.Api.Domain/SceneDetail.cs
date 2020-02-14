using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SceneDetail : AopObject
	{
		[XmlElement("desc")]
		public string Desc
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

		[XmlElement("scene_image")]
		public string SceneImage
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}
	}
}

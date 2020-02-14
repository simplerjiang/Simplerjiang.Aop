using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Scene : AopObject
	{
		[XmlElement("scene_id")]
		public string SceneId
		{
			get;
			set;
		}
	}
}

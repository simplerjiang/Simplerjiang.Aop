using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseSceneContentQueryModel : AopObject
	{
		[XmlElement("city_id")]
		public string CityId
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

		[XmlElement("top_size")]
		public long TopSize
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

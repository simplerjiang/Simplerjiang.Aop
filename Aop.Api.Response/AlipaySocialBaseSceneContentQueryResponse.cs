using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySocialBaseSceneContentQueryResponse : AopResponse
	{
		[XmlArray("scene_content")]
		[XmlArrayItem("scene_content")]
		public List<SceneContent> SceneContent
		{
			get;
			set;
		}

		[XmlElement("scene_detail")]
		public SceneDetail SceneDetail
		{
			get;
			set;
		}

		[XmlElement("scheme")]
		public string Scheme
		{
			get;
			set;
		}
	}
}

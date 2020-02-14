using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataSceneTravelGetResponse : AopResponse
	{
		[XmlArray("content")]
		[XmlArrayItem("scene_marketing_content_group")]
		public List<SceneMarketingContentGroup> Content
		{
			get;
			set;
		}

		[XmlElement("header")]
		public SceneMarketingHeader Header
		{
			get;
			set;
		}
	}
}

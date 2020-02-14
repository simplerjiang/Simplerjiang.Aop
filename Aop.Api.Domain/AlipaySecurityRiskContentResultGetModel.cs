using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskContentResultGetModel : AopObject
	{
		[XmlElement("app_scene")]
		public string AppScene
		{
			get;
			set;
		}

		[XmlElement("app_scene_data_id")]
		public string AppSceneDataId
		{
			get;
			set;
		}

		[XmlElement("event_id")]
		public string EventId
		{
			get;
			set;
		}
	}
}

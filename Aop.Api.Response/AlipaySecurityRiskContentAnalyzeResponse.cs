using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskContentAnalyzeResponse : AopResponse
	{
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

		[XmlArray("hit_detect_items")]
		[XmlArrayItem("info_sec_hit_detect_item")]
		public List<InfoSecHitDetectItem> HitDetectItems
		{
			get;
			set;
		}

		[XmlElement("need_query")]
		public string NeedQuery
		{
			get;
			set;
		}

		[XmlElement("result_action")]
		public string ResultAction
		{
			get;
			set;
		}
	}
}

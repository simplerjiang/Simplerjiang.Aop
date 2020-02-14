using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskContentResultGetResponse : AopResponse
	{
		[XmlArray("hit_detect_items")]
		[XmlArrayItem("info_sec_hit_detect_item")]
		public List<InfoSecHitDetectItem> HitDetectItems
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

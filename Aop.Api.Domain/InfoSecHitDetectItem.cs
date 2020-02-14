using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InfoSecHitDetectItem : AopObject
	{
		[XmlElement("detect_resource_level")]
		public string DetectResourceLevel
		{
			get;
			set;
		}

		[XmlElement("detect_type_code")]
		public string DetectTypeCode
		{
			get;
			set;
		}

		[XmlElement("hit_content")]
		public string HitContent
		{
			get;
			set;
		}

		[XmlElement("hit_detect_resource")]
		public string HitDetectResource
		{
			get;
			set;
		}
	}
}

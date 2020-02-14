using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TemplateCardLevelConfDTO : AopObject
	{
		[XmlElement("level")]
		public string Level
		{
			get;
			set;
		}

		[XmlElement("level_desc")]
		public string LevelDesc
		{
			get;
			set;
		}

		[XmlElement("level_icon")]
		public string LevelIcon
		{
			get;
			set;
		}

		[XmlElement("level_show_name")]
		public string LevelShowName
		{
			get;
			set;
		}
	}
}

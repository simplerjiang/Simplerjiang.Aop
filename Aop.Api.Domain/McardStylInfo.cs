using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class McardStylInfo : AopObject
	{
		[XmlElement("background_id")]
		public string BackgroundId
		{
			get;
			set;
		}

		[XmlElement("bg_color")]
		public string BgColor
		{
			get;
			set;
		}

		[XmlElement("logo_id")]
		public string LogoId
		{
			get;
			set;
		}
	}
}

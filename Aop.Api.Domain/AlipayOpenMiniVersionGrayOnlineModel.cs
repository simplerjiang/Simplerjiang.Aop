using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenMiniVersionGrayOnlineModel : AopObject
	{
		[XmlElement("app_version")]
		public string AppVersion
		{
			get;
			set;
		}

		[XmlElement("gray_strategy")]
		public string GrayStrategy
		{
			get;
			set;
		}
	}
}

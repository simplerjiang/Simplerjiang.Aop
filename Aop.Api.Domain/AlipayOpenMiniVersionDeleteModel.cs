using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenMiniVersionDeleteModel : AopObject
	{
		[XmlElement("app_version")]
		public string AppVersion
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenMiniExperienceCancelModel : AopObject
	{
		[XmlElement("app_version")]
		public string AppVersion
		{
			get;
			set;
		}
	}
}

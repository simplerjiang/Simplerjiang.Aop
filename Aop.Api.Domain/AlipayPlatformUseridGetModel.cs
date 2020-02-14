using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayPlatformUseridGetModel : AopObject
	{
		[XmlArray("open_ids")]
		[XmlArrayItem("string")]
		public List<string> OpenIds
		{
			get;
			set;
		}
	}
}

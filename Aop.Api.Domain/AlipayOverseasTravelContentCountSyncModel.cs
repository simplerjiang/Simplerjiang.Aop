using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOverseasTravelContentCountSyncModel : AopObject
	{
		[XmlArray("count_infos")]
		[XmlArrayItem("count_info")]
		public List<CountInfo> CountInfos
		{
			get;
			set;
		}
	}
}

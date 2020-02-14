using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SettleInfo : AopObject
	{
		[XmlArray("settle_detail_infos")]
		[XmlArrayItem("settle_detail_info")]
		public List<SettleDetailInfo> SettleDetailInfos
		{
			get;
			set;
		}
	}
}

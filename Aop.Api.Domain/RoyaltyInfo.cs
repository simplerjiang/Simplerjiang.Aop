using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RoyaltyInfo : AopObject
	{
		[XmlArray("royalty_detail_infos")]
		[XmlArrayItem("royalty_detail_infos")]
		public List<RoyaltyDetailInfos> RoyaltyDetailInfos
		{
			get;
			set;
		}

		[XmlElement("royalty_type")]
		public string RoyaltyType
		{
			get;
			set;
		}
	}
}

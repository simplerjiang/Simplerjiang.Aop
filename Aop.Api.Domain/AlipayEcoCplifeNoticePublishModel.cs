using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoCplifeNoticePublishModel : AopObject
	{
		[XmlArray("community_id_set")]
		[XmlArrayItem("string")]
		public List<string> CommunityIdSet
		{
			get;
			set;
		}

		[XmlElement("notice_details")]
		public CplifeNoticeDetail NoticeDetails
		{
			get;
			set;
		}
	}
}

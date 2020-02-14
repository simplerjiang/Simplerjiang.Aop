using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	[Serializable]
	public class AlipayUserInviteOfflinedetailQueryResponse : AopResponse
	{
		[XmlArray("offline_detail_info_list")]
		[XmlArrayItem("offline_detail_info")]
		public List<OfflineDetailInfo> OfflineDetailInfoList
		{
			get;
			set;
		}

		[XmlElement("total_page")]
		public int TotalPage
		{
			get;
			set;
		}

		[XmlElement("total_count")]
		public int TotalCount
		{
			get;
			set;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	[Serializable]
	public class AlipayUserInviteOfflinesummaryQueryResponse : AopResponse
	{
		[XmlArray("offline_summary_info_list")]
		[XmlArrayItem("offline_summary_info")]
		public List<OfflineInviteNewerSummaryInfoItem> OfflineInviteNewerSummaryInfoList
		{
			get;
			set;
		}
	}
}

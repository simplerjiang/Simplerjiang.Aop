using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoCplifeCommunityBatchqueryResponse : AopResponse
	{
		[XmlArray("community_list")]
		[XmlArrayItem("c_p_community_set")]
		public List<CPCommunitySet> CommunityList
		{
			get;
			set;
		}

		[XmlElement("current_page_num")]
		public long CurrentPageNum
		{
			get;
			set;
		}

		[XmlElement("total_community_count")]
		public long TotalCommunityCount
		{
			get;
			set;
		}
	}
}

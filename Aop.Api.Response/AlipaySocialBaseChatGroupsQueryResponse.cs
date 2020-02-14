using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySocialBaseChatGroupsQueryResponse : AopResponse
	{
		[XmlArray("group_infos")]
		[XmlArrayItem("group_info")]
		public List<GroupInfo> GroupInfos
		{
			get;
			set;
		}

		[XmlElement("has_more")]
		public bool HasMore
		{
			get;
			set;
		}

		[XmlElement("last_key")]
		public long LastKey
		{
			get;
			set;
		}
	}
}

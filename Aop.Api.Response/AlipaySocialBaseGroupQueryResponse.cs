using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySocialBaseGroupQueryResponse : AopResponse
	{
		[XmlElement("group_id")]
		public string GroupId
		{
			get;
			set;
		}

		[XmlElement("group_member_count")]
		public long GroupMemberCount
		{
			get;
			set;
		}

		[XmlArray("group_members")]
		[XmlArrayItem("group_member_info")]
		public List<GroupMemberInfo> GroupMembers
		{
			get;
			set;
		}

		[XmlElement("group_name")]
		public string GroupName
		{
			get;
			set;
		}
	}
}

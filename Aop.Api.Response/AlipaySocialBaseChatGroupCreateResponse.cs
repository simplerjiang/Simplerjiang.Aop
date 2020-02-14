using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySocialBaseChatGroupCreateResponse : AopResponse
	{
		[XmlElement("group_info")]
		public GroupInfo GroupInfo
		{
			get;
			set;
		}

		[XmlArray("member_infos")]
		[XmlArrayItem("member_info")]
		public List<MemberInfo> MemberInfos
		{
			get;
			set;
		}
	}
}

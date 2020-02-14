using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAppMembersQueryResponse : AopResponse
	{
		[XmlArray("app_member_info_list")]
		[XmlArrayItem("app_member_info")]
		public List<AppMemberInfo> AppMemberInfoList
		{
			get;
			set;
		}
	}
}

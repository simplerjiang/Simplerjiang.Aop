using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertCommissionRoleQueryResponse : AopResponse
	{
		[XmlArray("role_infos")]
		[XmlArrayItem("kbadvert_role_info_response")]
		public List<KbadvertRoleInfoResponse> RoleInfos
		{
			get;
			set;
		}
	}
}

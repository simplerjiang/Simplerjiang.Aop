using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDatabizCoreUserLevelGetResponse : AopResponse
	{
		[XmlArray("user_level_infos")]
		[XmlArrayItem("alipay_user_level_info")]
		public List<AlipayUserLevelInfo> UserLevelInfos
		{
			get;
			set;
		}
	}
}

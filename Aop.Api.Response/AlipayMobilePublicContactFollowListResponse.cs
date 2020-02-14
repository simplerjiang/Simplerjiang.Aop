using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicContactFollowListResponse : AopResponse
	{
		[XmlElement("code")]
		public new string Code
		{
			get;
			set;
		}

		[XmlArray("contact_follow_list")]
		[XmlArrayItem("string")]
		public List<string> ContactFollowList
		{
			get;
			set;
		}
	}
}

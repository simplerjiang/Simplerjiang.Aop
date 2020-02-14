using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicContactFollowBatchqueryResponse : AopResponse
	{
		[XmlArray("contact_follow_list")]
		[XmlArrayItem("contact_follower")]
		public List<ContactFollower> ContactFollowList
		{
			get;
			set;
		}
	}
}

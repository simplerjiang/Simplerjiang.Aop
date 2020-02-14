using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicFollowBatchqueryResponse : AopResponse
	{
		[XmlElement("count")]
		public string Count
		{
			get;
			set;
		}

		[XmlElement("next_user_id")]
		public string NextUserId
		{
			get;
			set;
		}

		[XmlArray("user_id_list")]
		[XmlArrayItem("string")]
		public List<string> UserIdList
		{
			get;
			set;
		}
	}
}

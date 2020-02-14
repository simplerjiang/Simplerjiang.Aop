using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobileStdPublicFollowListResponse : AopResponse
	{
		[XmlElement("count")]
		public string Count
		{
			get;
			set;
		}

		[XmlElement("data")]
		public Data Data
		{
			get;
			set;
		}

		[XmlElement("next_alipay_user_id")]
		public string NextAlipayUserId
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
	}
}

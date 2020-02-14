using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoCplifeCommunityCreateResponse : AopResponse
	{
		[XmlElement("community_id")]
		public string CommunityId
		{
			get;
			set;
		}

		[XmlElement("next_action")]
		public string NextAction
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoCplifeCommunityModifyResponse : AopResponse
	{
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

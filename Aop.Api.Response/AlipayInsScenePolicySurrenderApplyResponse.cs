using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsScenePolicySurrenderApplyResponse : AopResponse
	{
		[XmlElement("policy_no")]
		public string PolicyNo
		{
			get;
			set;
		}
	}
}

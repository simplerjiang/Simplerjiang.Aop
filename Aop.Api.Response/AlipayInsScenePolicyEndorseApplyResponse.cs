using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsScenePolicyEndorseApplyResponse : AopResponse
	{
		[XmlElement("endorse_no")]
		public string EndorseNo
		{
			get;
			set;
		}

		[XmlElement("out_request_no")]
		public string OutRequestNo
		{
			get;
			set;
		}
	}
}

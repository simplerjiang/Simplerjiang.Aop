using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAgentCreateResponse : AopResponse
	{
		[XmlElement("batch_no")]
		public string BatchNo
		{
			get;
			set;
		}

		[XmlElement("batch_status")]
		public string BatchStatus
		{
			get;
			set;
		}
	}
}

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataDataserviceRiskAudioVerifyResponse : AopResponse
	{
		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}

		[XmlElement("unique_id")]
		public string UniqueId
		{
			get;
			set;
		}
	}
}

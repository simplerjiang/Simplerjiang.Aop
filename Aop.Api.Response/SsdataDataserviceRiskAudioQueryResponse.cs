using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataDataserviceRiskAudioQueryResponse : AopResponse
	{
		[XmlElement("risk_result")]
		public string RiskResult
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

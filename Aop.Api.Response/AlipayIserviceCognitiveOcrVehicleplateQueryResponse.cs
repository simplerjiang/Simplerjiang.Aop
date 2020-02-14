using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayIserviceCognitiveOcrVehicleplateQueryResponse : AopResponse
	{
		[XmlElement("error_content")]
		public string ErrorContent
		{
			get;
			set;
		}

		[XmlElement("prob")]
		public string Prob
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}

		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}

		[XmlElement("trace_id")]
		public string TraceId
		{
			get;
			set;
		}

		[XmlElement("txt")]
		public string Txt
		{
			get;
			set;
		}
	}
}

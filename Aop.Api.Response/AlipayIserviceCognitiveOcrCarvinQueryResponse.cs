using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayIserviceCognitiveOcrCarvinQueryResponse : AopResponse
	{
		[XmlElement("request_id")]
		public string RequestId
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

		[XmlElement("vin")]
		public string Vin
		{
			get;
			set;
		}
	}
}

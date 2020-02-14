using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayIserviceCognitiveBillInferenceQueryResponse : AopResponse
	{
		[XmlElement("result")]
		public BillInferenceResult Result
		{
			get;
			set;
		}

		[XmlElement("ret")]
		public long Ret
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
	}
}

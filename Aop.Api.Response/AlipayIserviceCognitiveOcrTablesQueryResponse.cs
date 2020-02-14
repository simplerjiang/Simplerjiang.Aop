using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayIserviceCognitiveOcrTablesQueryResponse : AopResponse
	{
		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}

		[XmlArray("tables")]
		[XmlArrayItem("ai_ocr_table_row")]
		public List<AiOcrTableRow> Tables
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

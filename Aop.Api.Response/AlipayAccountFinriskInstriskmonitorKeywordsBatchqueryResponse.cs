using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayAccountFinriskInstriskmonitorKeywordsBatchqueryResponse : AopResponse
	{
		[XmlArray("result")]
		[XmlArrayItem("string")]
		public List<string> Result
		{
			get;
			set;
		}
	}
}

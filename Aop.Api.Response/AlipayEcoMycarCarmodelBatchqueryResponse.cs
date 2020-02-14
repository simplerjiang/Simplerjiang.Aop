using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarCarmodelBatchqueryResponse : AopResponse
	{
		[XmlElement("query_result")]
		public QueryResult QueryResult
		{
			get;
			set;
		}

		[XmlElement("query_type")]
		public string QueryType
		{
			get;
			set;
		}
	}
}

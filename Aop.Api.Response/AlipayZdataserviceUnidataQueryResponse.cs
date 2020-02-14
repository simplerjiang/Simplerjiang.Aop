using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayZdataserviceUnidataQueryResponse : AopResponse
	{
		[XmlElement("query_result")]
		public string QueryResult
		{
			get;
			set;
		}

		[XmlElement("result_code")]
		public string ResultCode
		{
			get;
			set;
		}

		[XmlElement("success")]
		public string Success
		{
			get;
			set;
		}
	}
}

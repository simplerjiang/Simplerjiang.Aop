using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskOfflinevarsQueryResponse : AopResponse
	{
		[XmlElement("query_result")]
		public string QueryResult
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

		[XmlElement("unique_id")]
		public string UniqueId
		{
			get;
			set;
		}
	}
}

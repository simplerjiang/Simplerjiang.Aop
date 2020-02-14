using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarDataExternalQueryResponse : AopResponse
	{
		[XmlElement("external_system_name")]
		public string ExternalSystemName
		{
			get;
			set;
		}

		[XmlElement("query_result")]
		public string QueryResult
		{
			get;
			set;
		}
	}
}

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingDataDeerInsightQueryResponse : AopResponse
	{
		[XmlElement("result")]
		public string Result
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
	}
}

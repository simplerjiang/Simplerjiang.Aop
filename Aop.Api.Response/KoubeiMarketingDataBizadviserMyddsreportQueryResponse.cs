using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataBizadviserMyddsreportQueryResponse : AopResponse
	{
		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}
	}
}

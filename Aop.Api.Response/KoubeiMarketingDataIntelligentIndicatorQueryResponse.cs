using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataIntelligentIndicatorQueryResponse : AopResponse
	{
		[XmlElement("indicator_infos")]
		public string IndicatorInfos
		{
			get;
			set;
		}
	}
}

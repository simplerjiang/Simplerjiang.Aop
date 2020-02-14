using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataMallIndicatorQueryResponse : AopResponse
	{
		[XmlElement("indicator_infos")]
		public string IndicatorInfos
		{
			get;
			set;
		}

		[XmlElement("total_size")]
		public long TotalSize
		{
			get;
			set;
		}
	}
}

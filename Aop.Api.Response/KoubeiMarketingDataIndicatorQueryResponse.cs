using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataIndicatorQueryResponse : AopResponse
	{
		[XmlElement("indicator_infos")]
		public string IndicatorInfos
		{
			get;
			set;
		}

		[XmlElement("total_size")]
		public string TotalSize
		{
			get;
			set;
		}
	}
}

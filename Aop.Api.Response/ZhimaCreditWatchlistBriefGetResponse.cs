using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditWatchlistBriefGetResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("level")]
		public string Level
		{
			get;
			set;
		}
	}
}

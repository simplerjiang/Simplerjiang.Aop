using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditScoreGetResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("zm_score")]
		public string ZmScore
		{
			get;
			set;
		}
	}
}

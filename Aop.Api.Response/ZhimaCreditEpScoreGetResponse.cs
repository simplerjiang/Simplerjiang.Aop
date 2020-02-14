using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditEpScoreGetResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("eval_date")]
		public string EvalDate
		{
			get;
			set;
		}

		[XmlElement("reason")]
		public string Reason
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

using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTradePaygrowthPayabilityQueryResponse : AopResponse
	{
		[XmlElement("enable_to_pay")]
		public bool EnableToPay
		{
			get;
			set;
		}

		[XmlElement("need_recommend")]
		public bool NeedRecommend
		{
			get;
			set;
		}

		[XmlElement("recommend_info")]
		public RecommendInfo RecommendInfo
		{
			get;
			set;
		}
	}
}

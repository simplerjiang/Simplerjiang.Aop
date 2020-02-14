using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobileRecommendGetResponse : AopResponse
	{
		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("items")]
		public string Items
		{
			get;
			set;
		}

		[XmlElement("recommend_id")]
		public string RecommendId
		{
			get;
			set;
		}
	}
}

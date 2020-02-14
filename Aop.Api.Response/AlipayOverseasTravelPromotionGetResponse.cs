using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOverseasTravelPromotionGetResponse : AopResponse
	{
		[XmlArray("promotions")]
		[XmlArrayItem("promotion_info")]
		public List<PromotionInfo> Promotions
		{
			get;
			set;
		}

		[XmlElement("total")]
		public long Total
		{
			get;
			set;
		}
	}
}

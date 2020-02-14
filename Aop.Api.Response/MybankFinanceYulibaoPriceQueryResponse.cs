using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankFinanceYulibaoPriceQueryResponse : AopResponse
	{
		[XmlArray("ylb_price_detail_infos")]
		[XmlArrayItem("y_l_b_price_detail_info")]
		public List<YLBPriceDetailInfo> YlbPriceDetailInfos
		{
			get;
			set;
		}
	}
}

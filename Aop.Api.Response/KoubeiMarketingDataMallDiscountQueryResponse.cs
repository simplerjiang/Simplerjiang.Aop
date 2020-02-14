using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataMallDiscountQueryResponse : AopResponse
	{
		[XmlArray("card_list")]
		[XmlArrayItem("card_info")]
		public List<CardInfo> CardList
		{
			get;
			set;
		}

		[XmlArray("code_coupon_list")]
		[XmlArrayItem("code_coupon_info")]
		public List<CodeCouponInfo> CodeCouponList
		{
			get;
			set;
		}

		[XmlArray("consume_list")]
		[XmlArrayItem("consume_info")]
		public List<ConsumeInfo> ConsumeList
		{
			get;
			set;
		}

		[XmlArray("reduce_list")]
		[XmlArrayItem("reduce_info")]
		public List<ReduceInfo> ReduceList
		{
			get;
			set;
		}
	}
}

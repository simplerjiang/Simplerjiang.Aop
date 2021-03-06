using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDataserviceShoppingmallrecVoucherQueryResponse : AopResponse
	{
		[XmlElement("recommend_id")]
		public string RecommendId
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}

		[XmlArray("voucher_recommend_list")]
		[XmlArrayItem("voucher_rec")]
		public List<VoucherRec> VoucherRecommendList
		{
			get;
			set;
		}
	}
}

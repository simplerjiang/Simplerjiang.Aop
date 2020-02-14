using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandMapplyorderQueryResponse : AopResponse
	{
		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}

		[XmlElement("order_status")]
		public string OrderStatus
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlArray("result_info")]
		[XmlArrayItem("merchant_apply_result_record")]
		public List<MerchantApplyResultRecord> ResultInfo
		{
			get;
			set;
		}
	}
}

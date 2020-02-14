using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradeOrderSettleModel : AopObject
	{
		[XmlElement("operator_id")]
		public string OperatorId
		{
			get;
			set;
		}

		[XmlElement("out_request_no")]
		public string OutRequestNo
		{
			get;
			set;
		}

		[XmlArray("royalty_parameters")]
		[XmlArrayItem("open_api_royalty_detail_info_pojo")]
		public List<OpenApiRoyaltyDetailInfoPojo> RoyaltyParameters
		{
			get;
			set;
		}

		[XmlElement("trade_no")]
		public string TradeNo
		{
			get;
			set;
		}
	}
}

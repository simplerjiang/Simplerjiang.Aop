using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsTradeInfo : AopObject
	{
		[XmlElement("product_no")]
		public string ProductNo
		{
			get;
			set;
		}

		[XmlElement("trade_biz_id")]
		public string TradeBizId
		{
			get;
			set;
		}
	}
}

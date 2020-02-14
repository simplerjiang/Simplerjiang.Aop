using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayAssetPointOrderCreateModel : AopObject
	{
		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("merchant_order_no")]
		public string MerchantOrderNo
		{
			get;
			set;
		}

		[XmlElement("order_time")]
		public string OrderTime
		{
			get;
			set;
		}

		[XmlElement("point_count")]
		public long PointCount
		{
			get;
			set;
		}

		[XmlElement("user_symbol")]
		public string UserSymbol
		{
			get;
			set;
		}

		[XmlElement("user_symbol_type")]
		public string UserSymbolType
		{
			get;
			set;
		}
	}
}

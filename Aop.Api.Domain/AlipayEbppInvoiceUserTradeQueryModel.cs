using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceUserTradeQueryModel : AopObject
	{
		[XmlElement("einv_trade_id")]
		public string EinvTradeId
		{
			get;
			set;
		}

		[XmlElement("random")]
		public string Random
		{
			get;
			set;
		}

		[XmlElement("timestamp")]
		public string Timestamp
		{
			get;
			set;
		}

		[XmlElement("token")]
		public string Token
		{
			get;
			set;
		}
	}
}

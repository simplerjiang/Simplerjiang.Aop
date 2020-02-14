using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppInvoiceUserTradeQueryResponse : AopResponse
	{
		[XmlElement("trade_info")]
		public InvoiceTradeInfo TradeInfo
		{
			get;
			set;
		}
	}
}

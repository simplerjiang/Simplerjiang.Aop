using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserTradeSearchResponse : AopResponse
	{
		[XmlElement("total_pages")]
		public string TotalPages
		{
			get;
			set;
		}

		[XmlElement("total_results")]
		public string TotalResults
		{
			get;
			set;
		}

		[XmlArray("trade_records")]
		[XmlArrayItem("trade_record")]
		public List<TradeRecord> TradeRecords
		{
			get;
			set;
		}
	}
}

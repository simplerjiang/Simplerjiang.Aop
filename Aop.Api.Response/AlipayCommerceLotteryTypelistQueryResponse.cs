using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceLotteryTypelistQueryResponse : AopResponse
	{
		[XmlArray("results")]
		[XmlArrayItem("lottery_type")]
		public List<LotteryType> Results
		{
			get;
			set;
		}

		[XmlElement("total_result")]
		public long TotalResult
		{
			get;
			set;
		}
	}
}

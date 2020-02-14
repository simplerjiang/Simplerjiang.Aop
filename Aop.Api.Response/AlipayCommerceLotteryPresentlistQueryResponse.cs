using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceLotteryPresentlistQueryResponse : AopResponse
	{
		[XmlArray("results")]
		[XmlArrayItem("lottery_present")]
		public List<LotteryPresent> Results
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

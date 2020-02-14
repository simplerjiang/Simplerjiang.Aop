using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcapiprodDrawndnRepaymentrecordQueryResponse : AopResponse
	{
		[XmlArray("repayment_records")]
		[XmlArrayItem("repayment_records")]
		public List<RepaymentRecords> RepaymentRecords
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
	}
}

using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcapiprodDrawndnFeerecordQueryResponse : AopResponse
	{
		[XmlArray("fee_records")]
		[XmlArrayItem("fee_records")]
		public List<FeeRecords> FeeRecords
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

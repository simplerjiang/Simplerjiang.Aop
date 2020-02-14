using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcapiprodDrawndnLendingrecordQueryResponse : AopResponse
	{
		[XmlArray("lending_records")]
		[XmlArrayItem("lending_records")]
		public List<LendingRecords> LendingRecords
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

using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTradeCustomsQueryResponse : AopResponse
	{
		[XmlElement("not_found")]
		public string NotFound
		{
			get;
			set;
		}

		[XmlArray("records")]
		[XmlArrayItem("customs_declare_record_info")]
		public List<CustomsDeclareRecordInfo> Records
		{
			get;
			set;
		}
	}
}

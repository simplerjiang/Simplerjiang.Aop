using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAccountSearchResponse : AopResponse
	{
		[XmlArray("account_records")]
		[XmlArrayItem("account_record")]
		public List<AccountRecord> AccountRecords
		{
			get;
			set;
		}

		[XmlElement("total_pages")]
		public long TotalPages
		{
			get;
			set;
		}

		[XmlElement("total_results")]
		public long TotalResults
		{
			get;
			set;
		}
	}
}

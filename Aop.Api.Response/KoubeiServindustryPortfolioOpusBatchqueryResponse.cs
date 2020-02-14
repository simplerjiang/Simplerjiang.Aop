using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiServindustryPortfolioOpusBatchqueryResponse : AopResponse
	{
		[XmlArray("opuses")]
		[XmlArrayItem("opus_info")]
		public List<OpusInfo> Opuses
		{
			get;
			set;
		}

		[XmlElement("total_size")]
		public long TotalSize
		{
			get;
			set;
		}
	}
}

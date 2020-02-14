using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsProducerBatchqueryResponse : AopResponse
	{
		[XmlArray("producers")]
		[XmlArrayItem("producer_v_o")]
		public List<ProducerVO> Producers
		{
			get;
			set;
		}

		[XmlElement("total_count")]
		public long TotalCount
		{
			get;
			set;
		}
	}
}

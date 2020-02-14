using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsProducerBatchqueryModel : AopObject
	{
		[XmlArray("producer_ids")]
		[XmlArrayItem("string")]
		public List<string> ProducerIds
		{
			get;
			set;
		}
	}
}

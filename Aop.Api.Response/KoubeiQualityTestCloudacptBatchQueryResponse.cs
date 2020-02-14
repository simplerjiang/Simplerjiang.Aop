using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiQualityTestCloudacptBatchQueryResponse : AopResponse
	{
		[XmlElement("activity_id")]
		public string ActivityId
		{
			get;
			set;
		}

		[XmlArray("batch_list")]
		[XmlArrayItem("open_batch")]
		public List<OpenBatch> BatchList
		{
			get;
			set;
		}

		[XmlElement("batch_num")]
		public string BatchNum
		{
			get;
			set;
		}
	}
}

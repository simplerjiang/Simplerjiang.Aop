using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdSignatureTaskQueryModel : AopObject
	{
		[XmlElement("biz_product")]
		public string BizProduct
		{
			get;
			set;
		}

		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlElement("service_version")]
		public string ServiceVersion
		{
			get;
			set;
		}

		[XmlArray("task_id_list")]
		[XmlArrayItem("string")]
		public List<string> TaskIdList
		{
			get;
			set;
		}
	}
}

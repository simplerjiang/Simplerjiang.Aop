using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdSignatureTaskCancelModel : AopObject
	{
		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("biz_product")]
		public string BizProduct
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

		[XmlElement("task_id")]
		public string TaskId
		{
			get;
			set;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdSignatureTaskApplyModel : AopObject
	{
		[XmlElement("biz_app")]
		public string BizApp
		{
			get;
			set;
		}

		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("biz_info")]
		public string BizInfo
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

		[XmlElement("order_type")]
		public long OrderType
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

		[XmlArray("sign_data_list")]
		[XmlArrayItem("sign_data_info")]
		public List<SignDataInfo> SignDataList
		{
			get;
			set;
		}

		[XmlArray("sign_task_list")]
		[XmlArrayItem("sign_task")]
		public List<SignTask> SignTaskList
		{
			get;
			set;
		}

		[XmlElement("sign_task_type")]
		public long SignTaskType
		{
			get;
			set;
		}
	}
}

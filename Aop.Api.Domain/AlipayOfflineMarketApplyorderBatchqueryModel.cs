using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineMarketApplyorderBatchqueryModel : AopObject
	{
		[XmlElement("action")]
		public string Action
		{
			get;
			set;
		}

		[XmlArray("apply_ids")]
		[XmlArrayItem("string")]
		public List<string> ApplyIds
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

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("end_time")]
		public string EndTime
		{
			get;
			set;
		}

		[XmlElement("op_id")]
		public string OpId
		{
			get;
			set;
		}

		[XmlElement("op_role")]
		public string OpRole
		{
			get;
			set;
		}

		[XmlElement("page_no")]
		public long PageNo
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}

		[XmlArray("request_ids")]
		[XmlArrayItem("string")]
		public List<string> RequestIds
		{
			get;
			set;
		}

		[XmlElement("start_time")]
		public string StartTime
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}

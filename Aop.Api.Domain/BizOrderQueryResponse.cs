using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BizOrderQueryResponse : AopObject
	{
		[XmlElement("action")]
		public string Action
		{
			get;
			set;
		}

		[XmlElement("action_mode")]
		public string ActionMode
		{
			get;
			set;
		}

		[XmlElement("apply_id")]
		public string ApplyId
		{
			get;
			set;
		}

		[XmlElement("biz_context_info")]
		public string BizContextInfo
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

		[XmlElement("create_time")]
		public string CreateTime
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

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}

		[XmlElement("result_code")]
		public string ResultCode
		{
			get;
			set;
		}

		[XmlElement("result_desc")]
		public string ResultDesc
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

		[XmlElement("sub_status")]
		public string SubStatus
		{
			get;
			set;
		}

		[XmlElement("update_time")]
		public string UpdateTime
		{
			get;
			set;
		}
	}
}

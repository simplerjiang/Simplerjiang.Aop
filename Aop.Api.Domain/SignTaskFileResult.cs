using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SignTaskFileResult : AopObject
	{
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

		[XmlArray("signed_file_list")]
		[XmlArrayItem("signed_file_info")]
		public List<SignedFileInfo> SignedFileList
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

		[XmlElement("task_id")]
		public string TaskId
		{
			get;
			set;
		}
	}
}

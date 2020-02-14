using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SignTaskResult : AopObject
	{
		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("sign_enter_url")]
		public string SignEnterUrl
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

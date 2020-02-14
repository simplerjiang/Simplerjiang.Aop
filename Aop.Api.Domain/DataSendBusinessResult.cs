using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DataSendBusinessResult : AopObject
	{
		[XmlElement("biz_code")]
		public string BizCode
		{
			get;
			set;
		}

		[XmlElement("biz_msg")]
		public string BizMsg
		{
			get;
			set;
		}
	}
}

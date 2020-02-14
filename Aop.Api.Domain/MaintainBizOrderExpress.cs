using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MaintainBizOrderExpress : AopObject
	{
		[XmlElement("create_time")]
		public string CreateTime
		{
			get;
			set;
		}

		[XmlElement("express_code")]
		public string ExpressCode
		{
			get;
			set;
		}

		[XmlElement("express_no")]
		public string ExpressNo
		{
			get;
			set;
		}

		[XmlElement("sender_addr")]
		public string SenderAddr
		{
			get;
			set;
		}
	}
}

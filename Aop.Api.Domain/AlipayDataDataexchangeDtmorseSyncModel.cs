using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataDataexchangeDtmorseSyncModel : AopObject
	{
		[XmlElement("data")]
		public string Data
		{
			get;
			set;
		}

		[XmlElement("extent_info")]
		public string ExtentInfo
		{
			get;
			set;
		}

		[XmlElement("mid")]
		public string Mid
		{
			get;
			set;
		}

		[XmlElement("operate_type")]
		public string OperateType
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MdCodeInfoDTO : AopObject
	{
		[XmlElement("code_status")]
		public string CodeStatus
		{
			get;
			set;
		}

		[XmlElement("code_value")]
		public string CodeValue
		{
			get;
			set;
		}

		[XmlElement("expire_time")]
		public string ExpireTime
		{
			get;
			set;
		}

		[XmlElement("time_stamp")]
		public long TimeStamp
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsSellerActivity : AopObject
	{
		[XmlElement("biz_data")]
		public string BizData
		{
			get;
			set;
		}

		[XmlElement("join_time")]
		public string JoinTime
		{
			get;
			set;
		}

		[XmlElement("status")]
		public long Status
		{
			get;
			set;
		}
	}
}

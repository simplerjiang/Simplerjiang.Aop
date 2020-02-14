using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserCharityForestSendModel : AopObject
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("biz_time")]
		public string BizTime
		{
			get;
			set;
		}

		[XmlElement("energy")]
		public long Energy
		{
			get;
			set;
		}

		[XmlElement("energy_type")]
		public string EnergyType
		{
			get;
			set;
		}

		[XmlElement("source")]
		public string Source
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}

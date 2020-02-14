using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayAccount : AopObject
	{
		[XmlElement("alipay_user_id")]
		public string AlipayUserId
		{
			get;
			set;
		}

		[XmlElement("available_amount")]
		public string AvailableAmount
		{
			get;
			set;
		}

		[XmlElement("freeze_amount")]
		public string FreezeAmount
		{
			get;
			set;
		}

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}
	}
}

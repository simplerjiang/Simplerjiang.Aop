using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradePaygrowthPayabilityQueryModel : AopObject
	{
		[XmlElement("biz_identity")]
		public string BizIdentity
		{
			get;
			set;
		}

		[XmlElement("real_pay_amount")]
		public string RealPayAmount
		{
			get;
			set;
		}

		[XmlElement("request_from")]
		public string RequestFrom
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

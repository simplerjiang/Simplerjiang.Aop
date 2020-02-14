using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PaymentAbilityQueryResponse : AopObject
	{
		[XmlElement("extra_infos")]
		public string ExtraInfos
		{
			get;
			set;
		}

		[XmlElement("level")]
		public string Level
		{
			get;
			set;
		}

		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}
	}
}

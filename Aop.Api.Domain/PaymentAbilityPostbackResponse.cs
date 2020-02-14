using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PaymentAbilityPostbackResponse : AopObject
	{
		[XmlElement("error_order")]
		public string ErrorOrder
		{
			get;
			set;
		}

		[XmlElement("order_ids")]
		public string OrderIds
		{
			get;
			set;
		}
	}
}

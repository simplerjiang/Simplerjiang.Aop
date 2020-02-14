using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BuyerPayDetail : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("pay_channel")]
		public string PayChannel
		{
			get;
			set;
		}
	}
}

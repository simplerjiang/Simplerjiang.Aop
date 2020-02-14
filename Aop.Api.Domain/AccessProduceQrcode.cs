using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AccessProduceQrcode : AopObject
	{
		[XmlElement("batch_id")]
		public string BatchId
		{
			get;
			set;
		}

		[XmlElement("core_url")]
		public string CoreUrl
		{
			get;
			set;
		}

		[XmlElement("produce_order_id")]
		public string ProduceOrderId
		{
			get;
			set;
		}

		[XmlElement("qrcode")]
		public string Qrcode
		{
			get;
			set;
		}
	}
}

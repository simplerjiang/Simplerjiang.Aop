using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RefundInfo : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("item_order_no")]
		public string ItemOrderNo
		{
			get;
			set;
		}
	}
}

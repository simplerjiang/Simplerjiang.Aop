using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringOrderInfoQueryModel : AopObject
	{
		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}
	}
}

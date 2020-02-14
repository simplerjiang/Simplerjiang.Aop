using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiTradeOrderQueryModel : AopObject
	{
		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiTradeItemorderQueryModel : AopObject
	{
		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}
	}
}

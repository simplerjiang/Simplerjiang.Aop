using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiShopMallAuditQueryModel : AopObject
	{
		[XmlElement("order_flow_id")]
		public string OrderFlowId
		{
			get;
			set;
		}
	}
}

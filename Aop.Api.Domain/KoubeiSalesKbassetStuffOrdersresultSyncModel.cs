using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiSalesKbassetStuffOrdersresultSyncModel : AopObject
	{
		[XmlArray("orders_feedback")]
		[XmlArrayItem("access_orders_feed_back")]
		public List<AccessOrdersFeedBack> OrdersFeedback
		{
			get;
			set;
		}
	}
}

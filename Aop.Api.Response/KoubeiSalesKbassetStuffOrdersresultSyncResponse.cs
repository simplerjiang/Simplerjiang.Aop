using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiSalesKbassetStuffOrdersresultSyncResponse : AopResponse
	{
		[XmlArray("orders_feedback_result")]
		[XmlArrayItem("access_orders_feed_back_result")]
		public List<AccessOrdersFeedBackResult> OrdersFeedbackResult
		{
			get;
			set;
		}
	}
}

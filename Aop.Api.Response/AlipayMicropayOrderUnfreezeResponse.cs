using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMicropayOrderUnfreezeResponse : AopResponse
	{
		[XmlElement("unfreeze_order_detail")]
		public UnfreezeOrderDetail UnfreezeOrderDetail
		{
			get;
			set;
		}
	}
}

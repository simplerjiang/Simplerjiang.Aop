using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertDeliveryDiscountQueryResponse : AopResponse
	{
		[XmlElement("discount")]
		public DiscountInfo Discount
		{
			get;
			set;
		}
	}
}

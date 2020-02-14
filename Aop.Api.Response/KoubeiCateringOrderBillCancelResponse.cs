using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringOrderBillCancelResponse : AopResponse
	{
		[XmlElement("retry")]
		public bool Retry
		{
			get;
			set;
		}
	}
}

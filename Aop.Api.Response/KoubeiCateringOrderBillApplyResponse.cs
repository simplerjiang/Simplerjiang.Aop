using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringOrderBillApplyResponse : AopResponse
	{
		[XmlElement("retry")]
		public bool Retry
		{
			get;
			set;
		}
	}
}

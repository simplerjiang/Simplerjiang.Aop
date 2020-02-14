using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringOrderInfoCancelResponse : AopResponse
	{
		[XmlElement("retry")]
		public bool Retry
		{
			get;
			set;
		}
	}
}

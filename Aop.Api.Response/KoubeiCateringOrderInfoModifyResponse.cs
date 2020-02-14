using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringOrderInfoModifyResponse : AopResponse
	{
		[XmlElement("retry")]
		public bool Retry
		{
			get;
			set;
		}
	}
}

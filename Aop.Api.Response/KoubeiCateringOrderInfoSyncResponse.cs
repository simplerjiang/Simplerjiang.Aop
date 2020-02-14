using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringOrderInfoSyncResponse : AopResponse
	{
		[XmlElement("retry")]
		public bool Retry
		{
			get;
			set;
		}
	}
}

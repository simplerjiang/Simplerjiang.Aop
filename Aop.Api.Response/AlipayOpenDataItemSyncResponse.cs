using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenDataItemSyncResponse : AopResponse
	{
		[XmlElement("external_id")]
		public string ExternalId
		{
			get;
			set;
		}
	}
}

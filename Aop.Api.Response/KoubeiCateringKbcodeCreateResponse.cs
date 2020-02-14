using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringKbcodeCreateResponse : AopResponse
	{
		[XmlElement("batch_id")]
		public string BatchId
		{
			get;
			set;
		}
	}
}

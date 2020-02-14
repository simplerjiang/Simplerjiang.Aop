using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringPosOrderUploadResponse : AopResponse
	{
		[XmlElement("flow_id")]
		public string FlowId
		{
			get;
			set;
		}
	}
}

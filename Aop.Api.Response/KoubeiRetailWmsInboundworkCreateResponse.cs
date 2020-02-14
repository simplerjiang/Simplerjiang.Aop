using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsInboundworkCreateResponse : AopResponse
	{
		[XmlElement("inbound_work_id")]
		public string InboundWorkId
		{
			get;
			set;
		}
	}
}

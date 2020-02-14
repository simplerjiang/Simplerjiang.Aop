using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsOutboundworkCreateResponse : AopResponse
	{
		[XmlElement("outbound_work_id")]
		public string OutboundWorkId
		{
			get;
			set;
		}
	}
}

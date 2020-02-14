using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsAutoUserCampaignQueryResponse : AopResponse
	{
		[XmlElement("register_status")]
		public string RegisterStatus
		{
			get;
			set;
		}
	}
}

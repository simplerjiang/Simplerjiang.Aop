using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingDataAntlogmngActivitypagespmCreateResponse : AopResponse
	{
		[XmlElement("issuc")]
		public bool Issuc
		{
			get;
			set;
		}

		[XmlElement("message")]
		public string Message
		{
			get;
			set;
		}
	}
}

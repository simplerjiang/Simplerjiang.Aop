using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicMessagebatchPushResponse : AopResponse
	{
		[XmlElement("code")]
		public new string Code
		{
			get;
			set;
		}

		[XmlElement("data")]
		public string Data
		{
			get;
			set;
		}

		[XmlElement("msg")]
		public new string Msg
		{
			get;
			set;
		}
	}
}

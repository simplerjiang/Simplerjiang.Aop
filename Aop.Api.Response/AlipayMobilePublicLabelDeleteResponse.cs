using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicLabelDeleteResponse : AopResponse
	{
		[XmlElement("code")]
		public new string Code
		{
			get;
			set;
		}

		[XmlElement("id")]
		public long Id
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

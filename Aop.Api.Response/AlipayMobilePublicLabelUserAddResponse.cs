using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicLabelUserAddResponse : AopResponse
	{
		[XmlElement("code")]
		public new string Code
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

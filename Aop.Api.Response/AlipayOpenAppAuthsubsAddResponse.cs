using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAppAuthsubsAddResponse : AopResponse
	{
		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}

		[XmlElement("invalid_date")]
		public string InvalidDate
		{
			get;
			set;
		}
	}
}

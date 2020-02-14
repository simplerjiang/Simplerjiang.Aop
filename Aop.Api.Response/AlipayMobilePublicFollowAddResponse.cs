using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicFollowAddResponse : AopResponse
	{
		[XmlElement("code")]
		public new string Code
		{
			get;
			set;
		}
	}
}

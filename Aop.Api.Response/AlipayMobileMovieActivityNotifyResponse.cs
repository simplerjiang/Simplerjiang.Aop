using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobileMovieActivityNotifyResponse : AopResponse
	{
		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}

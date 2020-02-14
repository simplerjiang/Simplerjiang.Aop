using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityDataInfoMobilecityQueryResponse : AopResponse
	{
		[XmlElement("mobile_city")]
		public SecuritydataMobileCity MobileCity
		{
			get;
			set;
		}
	}
}

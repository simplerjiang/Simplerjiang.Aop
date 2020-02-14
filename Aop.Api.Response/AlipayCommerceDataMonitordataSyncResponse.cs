using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceDataMonitordataSyncResponse : AopResponse
	{
		[XmlElement("error_detail")]
		public string ErrorDetail
		{
			get;
			set;
		}
	}
}

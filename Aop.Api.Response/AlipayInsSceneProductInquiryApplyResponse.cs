using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsSceneProductInquiryApplyResponse : AopResponse
	{
		[XmlElement("premium")]
		public long Premium
		{
			get;
			set;
		}
	}
}

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenMiniInnerbaseinfoCreateResponse : AopResponse
	{
		[XmlElement("mini_app_id")]
		public string MiniAppId
		{
			get;
			set;
		}
	}
}

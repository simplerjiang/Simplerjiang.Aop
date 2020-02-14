using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoRenthouseCommonImageUploadResponse : AopResponse
	{
		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}

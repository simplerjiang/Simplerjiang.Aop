using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsCooperationRegionQrcodeApplyResponse : AopResponse
	{
		[XmlElement("code_url")]
		public string CodeUrl
		{
			get;
			set;
		}
	}
}

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsCooperationProductQrcodeApplyResponse : AopResponse
	{
		[XmlElement("code_url")]
		public string CodeUrl
		{
			get;
			set;
		}
	}
}

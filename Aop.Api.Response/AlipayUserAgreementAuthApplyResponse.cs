using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAgreementAuthApplyResponse : AopResponse
	{
		[XmlElement("apply_token")]
		public string ApplyToken
		{
			get;
			set;
		}
	}
}

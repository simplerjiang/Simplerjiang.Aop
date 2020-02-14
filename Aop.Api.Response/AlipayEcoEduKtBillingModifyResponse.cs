using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoEduKtBillingModifyResponse : AopResponse
	{
		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}

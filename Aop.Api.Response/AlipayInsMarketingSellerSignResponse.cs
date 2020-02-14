using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsMarketingSellerSignResponse : AopResponse
	{
		[XmlElement("agreement_no")]
		public string AgreementNo
		{
			get;
			set;
		}
	}
}

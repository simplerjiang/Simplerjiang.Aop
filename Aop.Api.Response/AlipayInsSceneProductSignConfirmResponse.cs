using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsSceneProductSignConfirmResponse : AopResponse
	{
		[XmlElement("agreement_no")]
		public string AgreementNo
		{
			get;
			set;
		}
	}
}

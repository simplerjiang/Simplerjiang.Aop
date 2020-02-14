using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarDialogonlineAnswerPushResponse : AopResponse
	{
		[XmlElement("answer_id")]
		public string AnswerId
		{
			get;
			set;
		}
	}
}

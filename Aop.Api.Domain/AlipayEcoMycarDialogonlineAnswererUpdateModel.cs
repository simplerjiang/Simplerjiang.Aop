using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarDialogonlineAnswererUpdateModel : AopObject
	{
		[XmlElement("answer_id")]
		public string AnswerId
		{
			get;
			set;
		}

		[XmlElement("answer_status")]
		public string AnswerStatus
		{
			get;
			set;
		}
	}
}

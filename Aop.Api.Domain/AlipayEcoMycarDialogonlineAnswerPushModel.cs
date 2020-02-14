using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarDialogonlineAnswerPushModel : AopObject
	{
		[XmlElement("answer_content")]
		public string AnswerContent
		{
			get;
			set;
		}

		[XmlElement("answer_id")]
		public string AnswerId
		{
			get;
			set;
		}

		[XmlElement("answer_logo")]
		public string AnswerLogo
		{
			get;
			set;
		}

		[XmlElement("answer_name")]
		public string AnswerName
		{
			get;
			set;
		}

		[XmlElement("answer_pic")]
		public string AnswerPic
		{
			get;
			set;
		}

		[XmlElement("answer_time")]
		public string AnswerTime
		{
			get;
			set;
		}

		[XmlElement("answer_type")]
		public string AnswerType
		{
			get;
			set;
		}

		[XmlElement("content_type")]
		public string ContentType
		{
			get;
			set;
		}

		[XmlElement("question_id")]
		public string QuestionId
		{
			get;
			set;
		}
	}
}

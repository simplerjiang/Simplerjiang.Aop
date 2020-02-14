using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoEduCampusJobdeliverModifyModel : AopObject
	{
		[XmlElement("alipay_user_id")]
		public string AlipayUserId
		{
			get;
			set;
		}

		[XmlElement("comment")]
		public string Comment
		{
			get;
			set;
		}

		[XmlElement("content_var")]
		public string ContentVar
		{
			get;
			set;
		}

		[XmlElement("interview_location")]
		public string InterviewLocation
		{
			get;
			set;
		}

		[XmlElement("interview_time")]
		public string InterviewTime
		{
			get;
			set;
		}

		[XmlElement("latitude")]
		public string Latitude
		{
			get;
			set;
		}

		[XmlElement("longitude")]
		public string Longitude
		{
			get;
			set;
		}

		[XmlElement("source_code")]
		public string SourceCode
		{
			get;
			set;
		}

		[XmlElement("source_id")]
		public string SourceId
		{
			get;
			set;
		}

		[XmlElement("status")]
		public long Status
		{
			get;
			set;
		}

		[XmlElement("update_time")]
		public string UpdateTime
		{
			get;
			set;
		}
	}
}

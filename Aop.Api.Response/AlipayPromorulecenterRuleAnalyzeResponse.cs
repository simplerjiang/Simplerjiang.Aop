using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPromorulecenterRuleAnalyzeResponse : AopResponse
	{
		[XmlElement("fail_condition_msg")]
		public string FailConditionMsg
		{
			get;
			set;
		}

		[XmlElement("fail_condition_name")]
		public string FailConditionName
		{
			get;
			set;
		}

		[XmlElement("result_code")]
		public string ResultCode
		{
			get;
			set;
		}

		[XmlElement("success")]
		public string Success
		{
			get;
			set;
		}

		[XmlElement("triggered")]
		public string Triggered
		{
			get;
			set;
		}
	}
}

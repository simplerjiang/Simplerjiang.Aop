using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPassSyncUpdateResponse : AopResponse
	{
		[XmlElement("biz_result")]
		public string BizResult
		{
			get;
			set;
		}

		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}

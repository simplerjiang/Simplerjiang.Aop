using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTradePayConsultResponse : AopResponse
	{
		[XmlElement("extend_infos")]
		public string ExtendInfos
		{
			get;
			set;
		}

		[XmlElement("refer_result")]
		public string ReferResult
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

		[XmlElement("result_msg")]
		public string ResultMsg
		{
			get;
			set;
		}
	}
}

using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppIndustryBizinfoQueryResponse : AopResponse
	{
		[XmlElement("biz_inst")]
		public string BizInst
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("data_code")]
		public string DataCode
		{
			get;
			set;
		}

		[XmlElement("org_result_code")]
		public string OrgResultCode
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

		[XmlElement("result_context")]
		public string ResultContext
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

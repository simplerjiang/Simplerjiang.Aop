using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppIndustryBizinfoQueryModel : AopObject
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

		[XmlElement("request_context")]
		public string RequestContext
		{
			get;
			set;
		}
	}
}

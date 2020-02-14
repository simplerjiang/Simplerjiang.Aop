using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SsdataDataserviceDtevalDataanalysisSendModel : AopObject
	{
		[XmlElement("biz_number")]
		public string BizNumber
		{
			get;
			set;
		}

		[XmlElement("biz_source")]
		public string BizSource
		{
			get;
			set;
		}

		[XmlElement("data_content")]
		public string DataContent
		{
			get;
			set;
		}

		[XmlElement("process_biz_type")]
		public string ProcessBizType
		{
			get;
			set;
		}
	}
}

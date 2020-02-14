using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataMallIndicatorQueryModel : AopObject
	{
		[XmlElement("begin_date")]
		public string BeginDate
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

		[XmlElement("end_date")]
		public string EndDate
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("page_num")]
		public long PageNum
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}
	}
}

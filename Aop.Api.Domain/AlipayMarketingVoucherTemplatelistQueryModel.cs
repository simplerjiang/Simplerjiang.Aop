using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingVoucherTemplatelistQueryModel : AopObject
	{
		[XmlElement("create_end_time")]
		public string CreateEndTime
		{
			get;
			set;
		}

		[XmlElement("create_start_time")]
		public string CreateStartTime
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

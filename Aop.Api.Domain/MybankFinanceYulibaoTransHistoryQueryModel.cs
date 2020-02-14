using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankFinanceYulibaoTransHistoryQueryModel : AopObject
	{
		[XmlElement("end_date")]
		public string EndDate
		{
			get;
			set;
		}

		[XmlElement("fund_code")]
		public string FundCode
		{
			get;
			set;
		}

		[XmlElement("page")]
		public long Page
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

		[XmlElement("start_date")]
		public string StartDate
		{
			get;
			set;
		}
	}
}

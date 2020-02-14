using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataDishdiagnoseBatchqueryModel : AopObject
	{
		[XmlElement("item_diagnose_type")]
		public string ItemDiagnoseType
		{
			get;
			set;
		}

		[XmlElement("page_no")]
		public long PageNo
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

		[XmlElement("report_date")]
		public string ReportDate
		{
			get;
			set;
		}
	}
}

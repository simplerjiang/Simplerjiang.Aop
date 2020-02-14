using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsSupplierreportdetailQueryModel : AopObject
	{
		[XmlElement("supplier_report_id")]
		public string SupplierReportId
		{
			get;
			set;
		}
	}
}

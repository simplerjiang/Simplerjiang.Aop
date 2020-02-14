using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsSupplierreportdetailQueryResponse : AopResponse
	{
		[XmlElement("supplier_report")]
		public SupplierReport SupplierReport
		{
			get;
			set;
		}

		[XmlArray("supplier_report_details")]
		[XmlArrayItem("supplier_report_detail")]
		public List<SupplierReportDetail> SupplierReportDetails
		{
			get;
			set;
		}
	}
}

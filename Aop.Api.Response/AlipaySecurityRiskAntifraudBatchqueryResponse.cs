using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskAntifraudBatchqueryResponse : AopResponse
	{
		[XmlArray("company_relation_list")]
		[XmlArrayItem("string")]
		public List<string> CompanyRelationList
		{
			get;
			set;
		}

		[XmlArray("staff_company_relation_list")]
		[XmlArrayItem("string")]
		public List<string> StaffCompanyRelationList
		{
			get;
			set;
		}
	}
}

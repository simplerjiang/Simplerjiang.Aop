using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskAntifraudBatchqueryModel : AopObject
	{
		[XmlArray("company_list")]
		[XmlArrayItem("string")]
		public List<string> CompanyList
		{
			get;
			set;
		}

		[XmlElement("partner_name")]
		public string PartnerName
		{
			get;
			set;
		}

		[XmlArray("staff_list")]
		[XmlArrayItem("string")]
		public List<string> StaffList
		{
			get;
			set;
		}
	}
}

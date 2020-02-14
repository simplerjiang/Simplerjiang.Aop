using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataSmartmanagementDiagnoseResponse : AopResponse
	{
		[XmlArray("diagnose_result")]
		[XmlArrayItem("diagnose_result")]
		public List<DiagnoseResult> DiagnoseResult
		{
			get;
			set;
		}
	}
}

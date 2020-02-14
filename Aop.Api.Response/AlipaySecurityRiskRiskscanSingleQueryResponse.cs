using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskRiskscanSingleQueryResponse : AopResponse
	{
		[XmlElement("scan_result_data")]
		public string ScanResultData
		{
			get;
			set;
		}
	}
}

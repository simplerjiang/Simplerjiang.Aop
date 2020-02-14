using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataDataserviceYuebaoassetDetailSendModel : AopObject
	{
		[XmlArray("alm_report_data")]
		[XmlArrayItem("alm_report_data")]
		public List<AlmReportData> AlmReportData
		{
			get;
			set;
		}
	}
}

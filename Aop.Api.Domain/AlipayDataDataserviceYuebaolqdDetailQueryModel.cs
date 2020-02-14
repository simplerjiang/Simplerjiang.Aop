using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataDataserviceYuebaolqdDetailQueryModel : AopObject
	{
		[XmlElement("report_date")]
		public string ReportDate
		{
			get;
			set;
		}
	}
}

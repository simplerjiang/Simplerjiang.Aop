using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataAlisisReportBatchqueryModel : AopObject
	{
		[XmlElement("page")]
		public string Page
		{
			get;
			set;
		}

		[XmlElement("size")]
		public string Size
		{
			get;
			set;
		}
	}
}

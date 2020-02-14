using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataActivityReportQueryModel : AopObject
	{
		[XmlElement("biz_date")]
		public string BizDate
		{
			get;
			set;
		}

		[XmlElement("camp_id")]
		public string CampId
		{
			get;
			set;
		}
	}
}

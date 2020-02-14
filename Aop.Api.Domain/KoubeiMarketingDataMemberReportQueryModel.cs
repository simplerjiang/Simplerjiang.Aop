using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataMemberReportQueryModel : AopObject
	{
		[XmlElement("biz_date")]
		public string BizDate
		{
			get;
			set;
		}
	}
}

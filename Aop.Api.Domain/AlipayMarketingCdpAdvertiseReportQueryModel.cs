using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCdpAdvertiseReportQueryModel : AopObject
	{
		[XmlElement("ad_id")]
		public string AdId
		{
			get;
			set;
		}
	}
}

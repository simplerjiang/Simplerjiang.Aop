using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserStepcounterDataBatchqueryModel : AopObject
	{
		[XmlElement("end_date")]
		public string EndDate
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
		{
			get;
			set;
		}

		[XmlElement("start_date")]
		public string StartDate
		{
			get;
			set;
		}

		[XmlElement("time_zone")]
		public string TimeZone
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}

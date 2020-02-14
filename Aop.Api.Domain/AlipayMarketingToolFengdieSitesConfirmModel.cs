using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingToolFengdieSitesConfirmModel : AopObject
	{
		[XmlElement("activity_id")]
		public long ActivityId
		{
			get;
			set;
		}

		[XmlElement("offline_time")]
		public string OfflineTime
		{
			get;
			set;
		}

		[XmlElement("operator")]
		public string Operator
		{
			get;
			set;
		}

		[XmlElement("space_id")]
		public string SpaceId
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}

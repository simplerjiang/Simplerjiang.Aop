using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoEduJzApplyresultSyncModel : AopObject
	{
		[XmlElement("apply_third_id")]
		public string ApplyThirdId
		{
			get;
			set;
		}

		[XmlElement("audit_remark")]
		public string AuditRemark
		{
			get;
			set;
		}

		[XmlElement("listing_status")]
		public string ListingStatus
		{
			get;
			set;
		}
	}
}

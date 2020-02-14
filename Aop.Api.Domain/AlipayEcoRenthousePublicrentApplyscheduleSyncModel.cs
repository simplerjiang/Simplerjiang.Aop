using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoRenthousePublicrentApplyscheduleSyncModel : AopObject
	{
		[XmlArray("apply_schedule_list")]
		[XmlArrayItem("eco_apply_schedule")]
		public List<EcoApplySchedule> ApplyScheduleList
		{
			get;
			set;
		}

		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("rent_id")]
		public string RentId
		{
			get;
			set;
		}
	}
}

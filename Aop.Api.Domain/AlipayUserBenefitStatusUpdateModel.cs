using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserBenefitStatusUpdateModel : AopObject
	{
		[XmlElement("benefit_id")]
		public string BenefitId
		{
			get;
			set;
		}

		[XmlElement("benefit_new_flag")]
		public string BenefitNewFlag
		{
			get;
			set;
		}

		[XmlElement("benefit_status")]
		public string BenefitStatus
		{
			get;
			set;
		}
	}
}

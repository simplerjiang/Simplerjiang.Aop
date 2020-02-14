using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BenefitInfo : AopObject
	{
		[XmlElement("benefit_info_id")]
		public string BenefitInfoId
		{
			get;
			set;
		}

		[XmlElement("benefit_name")]
		public string BenefitName
		{
			get;
			set;
		}

		[XmlElement("benefit_name_cn")]
		public string BenefitNameCn
		{
			get;
			set;
		}

		[XmlElement("benefit_type")]
		public string BenefitType
		{
			get;
			set;
		}

		[XmlElement("dispatch_dt")]
		public string DispatchDt
		{
			get;
			set;
		}

		[XmlElement("end_dt")]
		public string EndDt
		{
			get;
			set;
		}

		[XmlElement("start_dt")]
		public string StartDt
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

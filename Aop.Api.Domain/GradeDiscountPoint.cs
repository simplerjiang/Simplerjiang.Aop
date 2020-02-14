using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class GradeDiscountPoint : AopObject
	{
		[XmlElement("benefit_id")]
		public long BenefitId
		{
			get;
			set;
		}

		[XmlElement("discount_point")]
		public string DiscountPoint
		{
			get;
			set;
		}

		[XmlElement("grade")]
		public string Grade
		{
			get;
			set;
		}
	}
}

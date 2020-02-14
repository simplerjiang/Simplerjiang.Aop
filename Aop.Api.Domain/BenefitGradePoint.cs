using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BenefitGradePoint : AopObject
	{
		[XmlElement("benefit_id")]
		public string BenefitId
		{
			get;
			set;
		}

		[XmlArray("grade_points")]
		[XmlArrayItem("grade_discount_point")]
		public List<GradeDiscountPoint> GradePoints
		{
			get;
			set;
		}

		[XmlElement("original_point")]
		public string OriginalPoint
		{
			get;
			set;
		}

		[XmlElement("own_grades")]
		public string OwnGrades
		{
			get;
			set;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CraftsmanAssessment : AopObject
	{
		[XmlArray("sub_assessments")]
		[XmlArrayItem("craftsman_sub_assessment")]
		public List<CraftsmanSubAssessment> SubAssessments
		{
			get;
			set;
		}

		[XmlElement("total_no")]
		public long TotalNo
		{
			get;
			set;
		}

		[XmlElement("total_score")]
		public long TotalScore
		{
			get;
			set;
		}
	}
}

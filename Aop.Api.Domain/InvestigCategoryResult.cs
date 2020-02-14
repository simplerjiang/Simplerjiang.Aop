using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InvestigCategoryResult : AopObject
	{
		[XmlElement("category")]
		public string Category
		{
			get;
			set;
		}

		[XmlArray("category_result")]
		[XmlArrayItem("investig_category_data")]
		public List<InvestigCategoryData> CategoryResult
		{
			get;
			set;
		}
	}
}

using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMerchantDepartmentLabelQueryResponse : AopResponse
	{
		[XmlArray("department_labels")]
		[XmlArrayItem("department_label")]
		public List<DepartmentLabel> DepartmentLabels
		{
			get;
			set;
		}
	}
}

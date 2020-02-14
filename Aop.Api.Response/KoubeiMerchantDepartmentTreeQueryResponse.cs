using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMerchantDepartmentTreeQueryResponse : AopResponse
	{
		[XmlArray("department_dtos")]
		[XmlArrayItem("department_d_t_o")]
		public List<DepartmentDTO> DepartmentDtos
		{
			get;
			set;
		}
	}
}

using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceCityfacilitatorFunctionQueryResponse : AopResponse
	{
		[XmlArray("functions")]
		[XmlArrayItem("support_function")]
		public List<SupportFunction> Functions
		{
			get;
			set;
		}
	}
}

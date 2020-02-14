using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsSceneApplicationBatchqueryResponse : AopResponse
	{
		[XmlArray("applications")]
		[XmlArrayItem("ins_application_query")]
		public List<InsApplicationQuery> Applications
		{
			get;
			set;
		}
	}
}

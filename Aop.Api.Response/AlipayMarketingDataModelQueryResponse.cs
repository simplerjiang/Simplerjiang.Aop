using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingDataModelQueryResponse : AopResponse
	{
		[XmlArray("model_column")]
		[XmlArrayItem("model_column")]
		public List<ModelColumn> ModelColumn
		{
			get;
			set;
		}
	}
}

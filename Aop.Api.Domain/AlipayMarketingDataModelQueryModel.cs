using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingDataModelQueryModel : AopObject
	{
		[XmlArray("model_query_param")]
		[XmlArrayItem("model_query_param")]
		public List<ModelQueryParam> ModelQueryParam
		{
			get;
			set;
		}

		[XmlElement("model_uk")]
		public string ModelUk
		{
			get;
			set;
		}
	}
}

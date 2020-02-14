using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceIotModellistCreateResponse : AopResponse
	{
		[XmlArray("duplicated_model_ids")]
		[XmlArrayItem("string")]
		public List<string> DuplicatedModelIds
		{
			get;
			set;
		}
	}
}

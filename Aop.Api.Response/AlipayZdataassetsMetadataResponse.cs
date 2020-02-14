using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayZdataassetsMetadataResponse : AopResponse
	{
		[XmlArray("result")]
		[XmlArrayItem("customer_entity")]
		public List<CustomerEntity> Result
		{
			get;
			set;
		}
	}
}

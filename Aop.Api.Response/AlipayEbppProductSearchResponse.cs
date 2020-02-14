using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppProductSearchResponse : AopResponse
	{
		[XmlArray("exproductconfs")]
		[XmlArrayItem("exproductconf_response")]
		public List<ExproductconfResponse> Exproductconfs
		{
			get;
			set;
		}
	}
}

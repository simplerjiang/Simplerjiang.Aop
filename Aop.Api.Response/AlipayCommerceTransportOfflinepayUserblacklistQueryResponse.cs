using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceTransportOfflinepayUserblacklistQueryResponse : AopResponse
	{
		[XmlArray("black_list")]
		[XmlArrayItem("string")]
		public List<string> BlackList
		{
			get;
			set;
		}
	}
}

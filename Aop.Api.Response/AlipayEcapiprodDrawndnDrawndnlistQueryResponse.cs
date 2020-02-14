using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcapiprodDrawndnDrawndnlistQueryResponse : AopResponse
	{
		[XmlArray("drawndn_list")]
		[XmlArrayItem("drawndn_vo")]
		public List<DrawndnVo> DrawndnList
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}
	}
}

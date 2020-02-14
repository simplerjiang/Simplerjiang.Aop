using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayAccountExrateAllclientrateQueryResponse : AopResponse
	{
		[XmlArray("client_rate_list")]
		[XmlArrayItem("ex_client_rate_v_o")]
		public List<ExClientRateVO> ClientRateList
		{
			get;
			set;
		}
	}
}

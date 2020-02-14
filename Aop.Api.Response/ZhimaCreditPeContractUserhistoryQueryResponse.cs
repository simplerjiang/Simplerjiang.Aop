using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditPeContractUserhistoryQueryResponse : AopResponse
	{
		[XmlArray("contract_history")]
		[XmlArrayItem("contract_basic_info")]
		public List<ContractBasicInfo> ContractHistory
		{
			get;
			set;
		}
	}
}

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFinancialnetAuthContractMerchantUnsignResponse : AopResponse
	{
		[XmlArray("contract_batch_no_list")]
		[XmlArrayItem("string")]
		public List<string> ContractBatchNoList
		{
			get;
			set;
		}

		[XmlArray("contract_no_list")]
		[XmlArrayItem("string")]
		public List<string> ContractNoList
		{
			get;
			set;
		}
	}
}

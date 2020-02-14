using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFinancialnetAuthContractMerchantSignResponse : AopResponse
	{
		[XmlElement("contract_batch_no")]
		public string ContractBatchNo
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

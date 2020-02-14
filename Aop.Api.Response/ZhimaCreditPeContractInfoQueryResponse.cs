using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditPeContractInfoQueryResponse : AopResponse
	{
		[XmlElement("contract_basic_info")]
		public ContractBasicInfo ContractBasicInfo
		{
			get;
			set;
		}

		[XmlElement("contract_status")]
		public long ContractStatus
		{
			get;
			set;
		}

		[XmlElement("contract_status_desc")]
		public string ContractStatusDesc
		{
			get;
			set;
		}
	}
}

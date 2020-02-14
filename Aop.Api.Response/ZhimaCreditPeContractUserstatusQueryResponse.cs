using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditPeContractUserstatusQueryResponse : AopResponse
	{
		[XmlElement("contract_basic_info")]
		public ContractBasicInfo ContractBasicInfo
		{
			get;
			set;
		}

		[XmlElement("user_status")]
		public long UserStatus
		{
			get;
			set;
		}

		[XmlElement("user_status_desc")]
		public string UserStatusDesc
		{
			get;
			set;
		}
	}
}

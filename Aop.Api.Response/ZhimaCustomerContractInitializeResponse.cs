using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCustomerContractInitializeResponse : AopResponse
	{
		[XmlElement("contract_no")]
		public string ContractNo
		{
			get;
			set;
		}
	}
}

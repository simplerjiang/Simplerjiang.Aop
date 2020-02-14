using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcapiprodDrawndnContractGetResponse : AopResponse
	{
		[XmlElement("contract_content")]
		public string ContractContent
		{
			get;
			set;
		}

		[XmlElement("contract_no")]
		public string ContractNo
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

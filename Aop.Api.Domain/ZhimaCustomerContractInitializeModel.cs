using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaCustomerContractInitializeModel : AopObject
	{
		[XmlElement("contract_file")]
		public string ContractFile
		{
			get;
			set;
		}

		[XmlElement("contract_name")]
		public string ContractName
		{
			get;
			set;
		}

		[XmlElement("product_code")]
		public string ProductCode
		{
			get;
			set;
		}
	}
}

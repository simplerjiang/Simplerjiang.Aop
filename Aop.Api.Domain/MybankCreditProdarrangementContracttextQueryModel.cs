using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditProdarrangementContracttextQueryModel : AopObject
	{
		[XmlElement("bsn_no")]
		public string BsnNo
		{
			get;
			set;
		}

		[XmlElement("contract_type")]
		public string ContractType
		{
			get;
			set;
		}

		[XmlElement("query_type")]
		public string QueryType
		{
			get;
			set;
		}
	}
}

using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMerchantOperatorSearchQueryResponse : AopResponse
	{
		[XmlArray("operator_list")]
		[XmlArrayItem("operator_base_info")]
		public List<OperatorBaseInfo> OperatorList
		{
			get;
			set;
		}

		[XmlElement("total")]
		public long Total
		{
			get;
			set;
		}
	}
}

using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMerchantOperatorRoleQueryResponse : AopResponse
	{
		[XmlArray("list")]
		[XmlArrayItem("koubei_merchant_role")]
		public List<KoubeiMerchantRole> List
		{
			get;
			set;
		}
	}
}

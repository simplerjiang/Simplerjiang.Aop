using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobileStdPublicAccountQueryResponse : AopResponse
	{
		[XmlArray("public_bind_accounts")]
		[XmlArrayItem("public_bind_account")]
		public List<PublicBindAccount> PublicBindAccounts
		{
			get;
			set;
		}
	}
}

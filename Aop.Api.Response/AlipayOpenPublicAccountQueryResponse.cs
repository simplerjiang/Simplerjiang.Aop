using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicAccountQueryResponse : AopResponse
	{
		[XmlArray("public_bind_accounts")]
		[XmlArrayItem("std_public_bind_account")]
		public List<StdPublicBindAccount> PublicBindAccounts
		{
			get;
			set;
		}
	}
}

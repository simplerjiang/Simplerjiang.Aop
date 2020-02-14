using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAccountFreezeGetResponse : AopResponse
	{
		[XmlArray("freeze_items")]
		[XmlArrayItem("account_freeze")]
		public List<AccountFreeze> FreezeItems
		{
			get;
			set;
		}

		[XmlElement("total_results")]
		public string TotalResults
		{
			get;
			set;
		}
	}
}

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAccountUseridBatchqueryResponse : AopResponse
	{
		[XmlArray("user_id_list")]
		[XmlArrayItem("string")]
		public List<string> UserIdList
		{
			get;
			set;
		}
	}
}

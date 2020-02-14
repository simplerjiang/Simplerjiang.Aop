using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingVoucherStockMatchResponse : AopResponse
	{
		[XmlArray("exist_list")]
		[XmlArrayItem("string")]
		public List<string> ExistList
		{
			get;
			set;
		}

		[XmlArray("not_exist_list")]
		[XmlArrayItem("string")]
		public List<string> NotExistList
		{
			get;
			set;
		}
	}
}

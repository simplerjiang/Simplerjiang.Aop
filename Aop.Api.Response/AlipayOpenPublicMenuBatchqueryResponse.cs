using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicMenuBatchqueryResponse : AopResponse
	{
		[XmlElement("count")]
		public string Count
		{
			get;
			set;
		}

		[XmlArray("menus")]
		[XmlArrayItem("query_menu")]
		public List<QueryMenu> Menus
		{
			get;
			set;
		}
	}
}

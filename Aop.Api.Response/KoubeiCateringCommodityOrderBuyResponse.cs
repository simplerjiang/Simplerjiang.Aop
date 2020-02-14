using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringCommodityOrderBuyResponse : AopResponse
	{
		[XmlArray("ext_info")]
		[XmlArrayItem("string")]
		public List<string> ExtInfo
		{
			get;
			set;
		}

		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlElement("order_result")]
		public string OrderResult
		{
			get;
			set;
		}

		[XmlElement("order_result_msg")]
		public string OrderResultMsg
		{
			get;
			set;
		}
	}
}

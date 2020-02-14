using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringItemlistQueryResponse : AopResponse
	{
		[XmlArray("item_list")]
		[XmlArrayItem("cater_item_list_info")]
		public List<CaterItemListInfo> ItemList
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}

		[XmlElement("total_amount")]
		public long TotalAmount
		{
			get;
			set;
		}
	}
}

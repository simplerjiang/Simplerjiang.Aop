using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsInventoryrecordQueryResponse : AopResponse
	{
		[XmlArray("inventory_record_list")]
		[XmlArrayItem("inventory_record")]
		public List<InventoryRecord> InventoryRecordList
		{
			get;
			set;
		}

		[XmlElement("page_no")]
		public string PageNo
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public string PageSize
		{
			get;
			set;
		}

		[XmlElement("total_count")]
		public string TotalCount
		{
			get;
			set;
		}
	}
}

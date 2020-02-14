using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiItemTaobaoIndexQueryResponse : AopResponse
	{
		[XmlElement("column_title")]
		public string ColumnTitle
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlArray("item_list")]
		[XmlArrayItem("kb_item_info")]
		public List<KbItemInfo> ItemList
		{
			get;
			set;
		}

		[XmlElement("time_icon")]
		public string TimeIcon
		{
			get;
			set;
		}

		[XmlElement("time_title")]
		public string TimeTitle
		{
			get;
			set;
		}

		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}

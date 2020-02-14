using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiQualityTestCloudacptItemQueryResponse : AopResponse
	{
		[XmlElement("activity_id")]
		public string ActivityId
		{
			get;
			set;
		}

		[XmlElement("batch_id")]
		public string BatchId
		{
			get;
			set;
		}

		[XmlElement("batch_status")]
		public string BatchStatus
		{
			get;
			set;
		}

		[XmlArray("fail_list")]
		[XmlArrayItem("open_item")]
		public List<OpenItem> FailList
		{
			get;
			set;
		}

		[XmlElement("fail_num")]
		public string FailNum
		{
			get;
			set;
		}

		[XmlArray("item_list")]
		[XmlArrayItem("open_item")]
		public List<OpenItem> ItemList
		{
			get;
			set;
		}

		[XmlElement("item_num")]
		public string ItemNum
		{
			get;
			set;
		}

		[XmlArray("pass_list")]
		[XmlArrayItem("open_item")]
		public List<OpenItem> PassList
		{
			get;
			set;
		}

		[XmlElement("pass_num")]
		public string PassNum
		{
			get;
			set;
		}
	}
}

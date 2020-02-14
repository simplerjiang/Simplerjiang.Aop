using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AssetInfoItem : AopObject
	{
		[XmlElement("assign_item_id")]
		public string AssignItemId
		{
			get;
			set;
		}

		[XmlElement("batch_no")]
		public string BatchNo
		{
			get;
			set;
		}

		[XmlElement("logistics_code")]
		public string LogisticsCode
		{
			get;
			set;
		}

		[XmlElement("logistics_no")]
		public string LogisticsNo
		{
			get;
			set;
		}

		[XmlElement("sub_type")]
		public string SubType
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}

		[XmlElement("value")]
		public string Value
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AccessPurchaseOrder : AopObject
	{
		[XmlElement("apply_date")]
		public string ApplyDate
		{
			get;
			set;
		}

		[XmlElement("asset_item_id")]
		public string AssetItemId
		{
			get;
			set;
		}

		[XmlElement("asset_order_id")]
		public string AssetOrderId
		{
			get;
			set;
		}

		[XmlElement("asset_purchase_id")]
		public string AssetPurchaseId
		{
			get;
			set;
		}

		[XmlElement("city")]
		public string City
		{
			get;
			set;
		}

		[XmlElement("count")]
		public string Count
		{
			get;
			set;
		}

		[XmlElement("create_date")]
		public string CreateDate
		{
			get;
			set;
		}

		[XmlElement("district")]
		public string District
		{
			get;
			set;
		}

		[XmlElement("is_produce")]
		public string IsProduce
		{
			get;
			set;
		}

		[XmlElement("province")]
		public string Province
		{
			get;
			set;
		}

		[XmlElement("receiver_address")]
		public string ReceiverAddress
		{
			get;
			set;
		}

		[XmlElement("receiver_mobile")]
		public string ReceiverMobile
		{
			get;
			set;
		}

		[XmlElement("receiver_name")]
		public string ReceiverName
		{
			get;
			set;
		}

		[XmlElement("stuff_attr_name")]
		public string StuffAttrName
		{
			get;
			set;
		}

		[XmlElement("stuff_material")]
		public string StuffMaterial
		{
			get;
			set;
		}

		[XmlElement("stuff_size")]
		public string StuffSize
		{
			get;
			set;
		}

		[XmlElement("stuff_type")]
		public string StuffType
		{
			get;
			set;
		}

		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}

		[XmlElement("template_name")]
		public string TemplateName
		{
			get;
			set;
		}
	}
}

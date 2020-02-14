using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AssetProduceItem : AopObject
	{
		[XmlElement("apply_date")]
		public string ApplyDate
		{
			get;
			set;
		}

		[XmlElement("apply_order_id")]
		public string ApplyOrderId
		{
			get;
			set;
		}

		[XmlElement("asset_pic_url")]
		public string AssetPicUrl
		{
			get;
			set;
		}

		[XmlElement("asset_resource")]
		public string AssetResource
		{
			get;
			set;
		}

		[XmlElement("assign_item_id")]
		public string AssignItemId
		{
			get;
			set;
		}

		[XmlElement("biz_tag")]
		public string BizTag
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

		[XmlElement("data_version")]
		public string DataVersion
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

		[XmlElement("logistics_code")]
		public string LogisticsCode
		{
			get;
			set;
		}

		[XmlElement("logistics_name")]
		public string LogisticsName
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

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("parent_template_id")]
		public string ParentTemplateId
		{
			get;
			set;
		}

		[XmlElement("postcode")]
		public string Postcode
		{
			get;
			set;
		}

		[XmlElement("print_data")]
		public string PrintData
		{
			get;
			set;
		}

		[XmlElement("produce_order")]
		public string ProduceOrder
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

		[XmlElement("supplier_pid")]
		public string SupplierPid
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

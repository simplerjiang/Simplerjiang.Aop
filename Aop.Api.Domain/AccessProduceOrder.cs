using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AccessProduceOrder : AopObject
	{
		[XmlElement("batch_id")]
		public string BatchId
		{
			get;
			set;
		}

		[XmlElement("produce_order_id")]
		public string ProduceOrderId
		{
			get;
			set;
		}

		[XmlElement("produce_quantity")]
		public long ProduceQuantity
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

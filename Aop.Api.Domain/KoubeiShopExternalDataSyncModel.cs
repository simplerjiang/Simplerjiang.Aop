using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiShopExternalDataSyncModel : AopObject
	{
		[XmlElement("action")]
		public string Action
		{
			get;
			set;
		}

		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}

		[XmlElement("data_source")]
		public string DataSource
		{
			get;
			set;
		}

		[XmlElement("data_version")]
		public long DataVersion
		{
			get;
			set;
		}

		[XmlElement("external_shop_id")]
		public string ExternalShopId
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}
	}
}

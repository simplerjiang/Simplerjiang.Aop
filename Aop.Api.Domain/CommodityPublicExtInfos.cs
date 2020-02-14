using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CommodityPublicExtInfos : AopObject
	{
		[XmlElement("action_url")]
		public string ActionUrl
		{
			get;
			set;
		}

		[XmlElement("app_id")]
		public string AppId
		{
			get;
			set;
		}

		[XmlElement("category_name")]
		public string CategoryName
		{
			get;
			set;
		}

		[XmlElement("city_name")]
		public string CityName
		{
			get;
			set;
		}

		[XmlElement("commodity_id")]
		public string CommodityId
		{
			get;
			set;
		}

		[XmlElement("create_user_id")]
		public string CreateUserId
		{
			get;
			set;
		}

		[XmlElement("displayapp_id")]
		public string DisplayappId
		{
			get;
			set;
		}

		[XmlElement("displayapp_memo")]
		public string DisplayappMemo
		{
			get;
			set;
		}

		[XmlElement("displayapp_name")]
		public string DisplayappName
		{
			get;
			set;
		}

		[XmlElement("displayapp_status")]
		public string DisplayappStatus
		{
			get;
			set;
		}

		[XmlElement("displayapp_url")]
		public string DisplayappUrl
		{
			get;
			set;
		}

		[XmlElement("export_url")]
		public string ExportUrl
		{
			get;
			set;
		}

		[XmlElement("property_id")]
		public string PropertyId
		{
			get;
			set;
		}
	}
}

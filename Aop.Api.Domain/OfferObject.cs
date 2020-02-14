using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OfferObject : AopObject
	{
		[XmlElement("app_code")]
		public string AppCode
		{
			get;
			set;
		}

		[XmlElement("category_code")]
		public string CategoryCode
		{
			get;
			set;
		}

		[XmlElement("city_code")]
		public string CityCode
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

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("gmt_modified")]
		public string GmtModified
		{
			get;
			set;
		}

		[XmlElement("logo_url")]
		public string LogoUrl
		{
			get;
			set;
		}

		[XmlElement("service_url")]
		public string ServiceUrl
		{
			get;
			set;
		}
	}
}

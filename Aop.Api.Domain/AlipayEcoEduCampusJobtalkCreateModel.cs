using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoEduCampusJobtalkCreateModel : AopObject
	{
		[XmlElement("campany_source")]
		public string CampanySource
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

		[XmlElement("city_code")]
		public string CityCode
		{
			get;
			set;
		}

		[XmlElement("company_lawname")]
		public string CompanyLawname
		{
			get;
			set;
		}

		[XmlElement("company_name")]
		public string CompanyName
		{
			get;
			set;
		}

		[XmlElement("content_var")]
		public string ContentVar
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

		[XmlElement("latitude")]
		public string Latitude
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

		[XmlElement("longitude")]
		public string Longitude
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

		[XmlElement("province_code")]
		public string ProvinceCode
		{
			get;
			set;
		}

		[XmlElement("street")]
		public string Street
		{
			get;
			set;
		}

		[XmlElement("talk_address")]
		public string TalkAddress
		{
			get;
			set;
		}

		[XmlElement("talk_content")]
		public string TalkContent
		{
			get;
			set;
		}

		[XmlElement("talk_endtime")]
		public string TalkEndtime
		{
			get;
			set;
		}

		[XmlElement("talk_holdtime")]
		public string TalkHoldtime
		{
			get;
			set;
		}

		[XmlElement("talk_school_code")]
		public string TalkSchoolCode
		{
			get;
			set;
		}

		[XmlElement("talk_school_name")]
		public string TalkSchoolName
		{
			get;
			set;
		}

		[XmlElement("talk_source_code")]
		public string TalkSourceCode
		{
			get;
			set;
		}

		[XmlElement("talk_source_id")]
		public string TalkSourceId
		{
			get;
			set;
		}

		[XmlElement("talk_title")]
		public string TalkTitle
		{
			get;
			set;
		}

		[XmlElement("talk_type")]
		public long TalkType
		{
			get;
			set;
		}

		[XmlElement("talksource_source")]
		public string TalksourceSource
		{
			get;
			set;
		}

		[XmlElement("web_url")]
		public string WebUrl
		{
			get;
			set;
		}
	}
}

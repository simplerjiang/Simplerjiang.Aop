using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoCplifeCommunityModifyModel : AopObject
	{
		[XmlArray("associated_pois")]
		[XmlArrayItem("string")]
		public List<string> AssociatedPois
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

		[XmlElement("community_address")]
		public string CommunityAddress
		{
			get;
			set;
		}

		[XmlElement("community_id")]
		public string CommunityId
		{
			get;
			set;
		}

		[XmlArray("community_locations")]
		[XmlArrayItem("string")]
		public List<string> CommunityLocations
		{
			get;
			set;
		}

		[XmlElement("community_name")]
		public string CommunityName
		{
			get;
			set;
		}

		[XmlElement("district_code")]
		public string DistrictCode
		{
			get;
			set;
		}

		[XmlElement("hotline")]
		public string Hotline
		{
			get;
			set;
		}

		[XmlElement("out_community_id")]
		public string OutCommunityId
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
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoRenthouseCommunityInfoSyncModel : AopObject
	{
		[XmlElement("address")]
		public string Address
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

		[XmlElement("city_name")]
		public string CityName
		{
			get;
			set;
		}

		[XmlElement("community_locations")]
		public string CommunityLocations
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

		[XmlElement("coordsys")]
		public string Coordsys
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

		[XmlElement("district_name")]
		public string DistrictName
		{
			get;
			set;
		}

		[XmlElement("poi")]
		public string Poi
		{
			get;
			set;
		}
	}
}

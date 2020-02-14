using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoRenthouseCommunityBaseinfoSyncModel : AopObject
	{
		[XmlElement("bus_code")]
		public string BusCode
		{
			get;
			set;
		}

		[XmlElement("bus_lat")]
		public string BusLat
		{
			get;
			set;
		}

		[XmlElement("bus_lng")]
		public string BusLng
		{
			get;
			set;
		}

		[XmlElement("bus_name")]
		public string BusName
		{
			get;
			set;
		}

		[XmlElement("bus_radius")]
		public long BusRadius
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

		[XmlElement("city_lat")]
		public string CityLat
		{
			get;
			set;
		}

		[XmlElement("city_lng")]
		public string CityLng
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

		[XmlElement("community_code")]
		public string CommunityCode
		{
			get;
			set;
		}

		[XmlElement("community_lat")]
		public string CommunityLat
		{
			get;
			set;
		}

		[XmlElement("community_lng")]
		public string CommunityLng
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

		[XmlElement("community_nong")]
		public string CommunityNong
		{
			get;
			set;
		}

		[XmlElement("community_street")]
		public string CommunityStreet
		{
			get;
			set;
		}

		[XmlElement("community_tag")]
		public string CommunityTag
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

		[XmlElement("district_lat")]
		public string DistrictLat
		{
			get;
			set;
		}

		[XmlElement("district_lng")]
		public string DistrictLng
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

		[XmlArray("subway_stations")]
		[XmlArrayItem("string")]
		public List<string> SubwayStations
		{
			get;
			set;
		}
	}
}

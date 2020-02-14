using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoCplifeCommunityDetailsQueryResponse : AopResponse
	{
		[XmlArray("associated_pois")]
		[XmlArrayItem("string")]
		public List<string> AssociatedPois
		{
			get;
			set;
		}

		[XmlElement("audit_status")]
		public string AuditStatus
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

		[XmlArray("community_services")]
		[XmlArrayItem("c_p_comm_services")]
		public List<CPCommServices> CommunityServices
		{
			get;
			set;
		}

		[XmlElement("community_status")]
		public string CommunityStatus
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

		[XmlElement("gmt_created")]
		public string GmtCreated
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

		[XmlElement("hotline")]
		public string Hotline
		{
			get;
			set;
		}

		[XmlElement("isv_pid")]
		public string IsvPid
		{
			get;
			set;
		}

		[XmlElement("merchant_firm_name")]
		public string MerchantFirmName
		{
			get;
			set;
		}

		[XmlElement("merchant_pid")]
		public string MerchantPid
		{
			get;
			set;
		}

		[XmlElement("next_action")]
		public string NextAction
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

		[XmlElement("qr_code_image")]
		public string QrCodeImage
		{
			get;
			set;
		}
	}
}

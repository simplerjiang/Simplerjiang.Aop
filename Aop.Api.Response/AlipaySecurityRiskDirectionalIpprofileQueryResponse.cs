using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskDirectionalIpprofileQueryResponse : AopResponse
	{
		[XmlElement("ip_address")]
		public string IpAddress
		{
			get;
			set;
		}

		[XmlElement("ip_carrier_city")]
		public string IpCarrierCity
		{
			get;
			set;
		}

		[XmlElement("ip_carrier_district")]
		public string IpCarrierDistrict
		{
			get;
			set;
		}

		[XmlElement("ip_carrier_province")]
		public string IpCarrierProvince
		{
			get;
			set;
		}

		[XmlElement("ip_gps_city")]
		public string IpGpsCity
		{
			get;
			set;
		}

		[XmlElement("ip_gps_district")]
		public string IpGpsDistrict
		{
			get;
			set;
		}

		[XmlElement("ip_gps_province")]
		public string IpGpsProvince
		{
			get;
			set;
		}

		[XmlElement("ip_latitude")]
		public string IpLatitude
		{
			get;
			set;
		}

		[XmlElement("ip_longitude")]
		public string IpLongitude
		{
			get;
			set;
		}

		[XmlElement("is_case_threemonth")]
		public string IsCaseThreemonth
		{
			get;
			set;
		}

		[XmlElement("is_cellular_ip")]
		public string IsCellularIp
		{
			get;
			set;
		}

		[XmlElement("is_edu_ip")]
		public string IsEduIp
		{
			get;
			set;
		}

		[XmlElement("is_idc_ip")]
		public string IsIdcIp
		{
			get;
			set;
		}

		[XmlElement("is_oversea_ip")]
		public string IsOverseaIp
		{
			get;
			set;
		}

		[XmlElement("is_proxy_ip")]
		public string IsProxyIp
		{
			get;
			set;
		}

		[XmlElement("net_cert_ratio")]
		public string NetCertRatio
		{
			get;
			set;
		}

		[XmlElement("net_phone_ratio")]
		public string NetPhoneRatio
		{
			get;
			set;
		}

		[XmlElement("unique_id")]
		public string UniqueId
		{
			get;
			set;
		}

		[XmlElement("usage_time_type")]
		public string UsageTimeType
		{
			get;
			set;
		}

		[XmlElement("user_cnt_halfyear")]
		public string UserCntHalfyear
		{
			get;
			set;
		}

		[XmlElement("user_cnt_weekavg")]
		public string UserCntWeekavg
		{
			get;
			set;
		}

		[XmlElement("user_cnt_weekstddev")]
		public string UserCntWeekstddev
		{
			get;
			set;
		}

		[XmlElement("user_stability")]
		public string UserStability
		{
			get;
			set;
		}
	}
}

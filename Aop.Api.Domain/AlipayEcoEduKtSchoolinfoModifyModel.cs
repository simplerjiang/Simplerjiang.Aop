using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoEduKtSchoolinfoModifyModel : AopObject
	{
		[XmlElement("bank_notify_url")]
		public string BankNotifyUrl
		{
			get;
			set;
		}

		[XmlElement("bank_partner_id")]
		public string BankPartnerId
		{
			get;
			set;
		}

		[XmlElement("bank_uid")]
		public string BankUid
		{
			get;
			set;
		}

		[XmlElement("bankcard_no")]
		public string BankcardNo
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

		[XmlElement("isv_name")]
		public string IsvName
		{
			get;
			set;
		}

		[XmlElement("isv_no")]
		public string IsvNo
		{
			get;
			set;
		}

		[XmlElement("isv_notify_url")]
		public string IsvNotifyUrl
		{
			get;
			set;
		}

		[XmlElement("isv_phone")]
		public string IsvPhone
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

		[XmlElement("province_code")]
		public string ProvinceCode
		{
			get;
			set;
		}

		[XmlElement("province_name")]
		public string ProvinceName
		{
			get;
			set;
		}

		[XmlElement("school_icon")]
		public string SchoolIcon
		{
			get;
			set;
		}

		[XmlElement("school_icon_type")]
		public string SchoolIconType
		{
			get;
			set;
		}

		[XmlElement("school_name")]
		public string SchoolName
		{
			get;
			set;
		}

		[XmlElement("school_pid")]
		public string SchoolPid
		{
			get;
			set;
		}

		[XmlElement("school_stdcode")]
		public string SchoolStdcode
		{
			get;
			set;
		}

		[XmlElement("school_type")]
		public string SchoolType
		{
			get;
			set;
		}

		[XmlElement("white_channel_code")]
		public string WhiteChannelCode
		{
			get;
			set;
		}
	}
}

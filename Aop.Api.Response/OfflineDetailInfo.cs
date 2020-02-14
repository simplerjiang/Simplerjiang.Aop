using System;
using System.Globalization;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	[Serializable]
	public class OfflineDetailInfo
	{
		[XmlElement("pid")]
		public string Pid
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
		{
			get;
			set;
		}

		[XmlElement("invited_phone")]
		public string InvitedPhone
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

		[XmlElement("city_name")]
		public string CityName
		{
			get;
			set;
		}

		[XmlElement("lbs_rate")]
		public string LbsRate
		{
			set
			{
				decimal.TryParse(value, out decimal result);
				LbsRateDeci = result;
			}
		}

		public decimal LbsRateDeci
		{
			get;
			private set;
		}

		[XmlElement("user_prize_time")]
		public string UserPrizeTime
		{
			set
			{
				DateTimeFormatInfo dateTimeFormatInfo = new DateTimeFormatInfo();
				dateTimeFormatInfo.ShortDatePattern = "yyyy-MM-dd HH:mm:ss";
				DateTime dateTime2 = UserPrizeTimeDateTime = Convert.ToDateTime(value, dateTimeFormatInfo);
			}
		}

		public DateTime UserPrizeTimeDateTime
		{
			get;
			set;
		}

		[XmlElement("user_cert_time")]
		public string UserCertTime
		{
			set
			{
				DateTimeFormatInfo dateTimeFormatInfo = new DateTimeFormatInfo();
				dateTimeFormatInfo.ShortDatePattern = "yyyy-MM-dd HH:mm:ss";
				DateTime dateTime2 = UserCertTimeDateTime = Convert.ToDateTime(value, dateTimeFormatInfo);
			}
		}

		public DateTime UserCertTimeDateTime
		{
			get;
			set;
		}

		[XmlElement("user_bind_card_time")]
		public string UserBindCardTime
		{
			set
			{
				DateTimeFormatInfo dateTimeFormatInfo = new DateTimeFormatInfo();
				dateTimeFormatInfo.ShortDatePattern = "yyyy-MM-dd HH:mm:ss";
				DateTime dateTime2 = UserBindCardTimeDateTime = Convert.ToDateTime(value, dateTimeFormatInfo);
			}
		}

		public DateTime UserBindCardTimeDateTime
		{
			get;
			set;
		}

		[XmlElement("settled")]
		public bool Settled
		{
			get;
			set;
		}

		[XmlElement("settled_and_bind")]
		public bool SettledAndBind
		{
			get;
			set;
		}
	}
}

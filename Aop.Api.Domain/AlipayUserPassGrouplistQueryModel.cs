using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserPassGrouplistQueryModel : AopObject
	{
		[XmlElement("city_code")]
		public string CityCode
		{
			get;
			set;
		}

		[XmlElement("group_type")]
		public string GroupType
		{
			get;
			set;
		}

		[XmlElement("need_shopinfo")]
		public bool NeedShopinfo
		{
			get;
			set;
		}

		[XmlElement("page_num")]
		public long PageNum
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
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

		[XmlElement("time_status")]
		public string TimeStatus
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}

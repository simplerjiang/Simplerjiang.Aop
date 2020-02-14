using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RecruitShopInfo : AopObject
	{
		[XmlElement("confirm_status")]
		public string ConfirmStatus
		{
			get;
			set;
		}

		[XmlElement("shop_category")]
		public string ShopCategory
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("shop_name")]
		public string ShopName
		{
			get;
			set;
		}
	}
}

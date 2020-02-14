using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntMerchantExpandIndirectActivityCreateModel : AopObject
	{
		[XmlElement("activity_type")]
		public string ActivityType
		{
			get;
			set;
		}

		[XmlElement("alias_name")]
		public string AliasName
		{
			get;
			set;
		}

		[XmlElement("business_license_pic")]
		public string BusinessLicensePic
		{
			get;
			set;
		}

		[XmlElement("checkstand_pic")]
		public string CheckstandPic
		{
			get;
			set;
		}

		[XmlElement("indoor_pic")]
		public string IndoorPic
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("settled_pic")]
		public string SettledPic
		{
			get;
			set;
		}

		[XmlElement("shop_entrance_pic")]
		public string ShopEntrancePic
		{
			get;
			set;
		}

		[XmlElement("sub_merchant_id")]
		public string SubMerchantId
		{
			get;
			set;
		}
	}
}

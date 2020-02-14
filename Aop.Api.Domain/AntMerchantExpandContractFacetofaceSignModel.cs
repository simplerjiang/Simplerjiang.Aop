using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntMerchantExpandContractFacetofaceSignModel : AopObject
	{
		[XmlElement("business_license_auth_pic")]
		public string BusinessLicenseAuthPic
		{
			get;
			set;
		}

		[XmlElement("business_license_no")]
		public string BusinessLicenseNo
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

		[XmlElement("contact_email")]
		public string ContactEmail
		{
			get;
			set;
		}

		[XmlElement("contact_mobile")]
		public string ContactMobile
		{
			get;
			set;
		}

		[XmlElement("contact_name")]
		public string ContactName
		{
			get;
			set;
		}

		[XmlElement("mcc_code")]
		public string MccCode
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("shop_scene_pic")]
		public string ShopScenePic
		{
			get;
			set;
		}

		[XmlElement("shop_sign_board_pic")]
		public string ShopSignBoardPic
		{
			get;
			set;
		}

		[XmlElement("special_license_pic")]
		public string SpecialLicensePic
		{
			get;
			set;
		}
	}
}

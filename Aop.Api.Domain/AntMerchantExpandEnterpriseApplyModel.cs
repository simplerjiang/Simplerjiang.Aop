using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntMerchantExpandEnterpriseApplyModel : AopObject
	{
		[XmlElement("base_info")]
		public BaseInfo BaseInfo
		{
			get;
			set;
		}

		[XmlElement("business_bank_account_info")]
		public BusinessBankAccountInfo BusinessBankAccountInfo
		{
			get;
			set;
		}

		[XmlElement("business_license_info")]
		public BusinessLicenceInfo BusinessLicenseInfo
		{
			get;
			set;
		}

		[XmlElement("legal_representative_info")]
		public LegalRepresentativeInfo LegalRepresentativeInfo
		{
			get;
			set;
		}

		[XmlElement("login_id")]
		public string LoginId
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

		[XmlElement("shop_info")]
		public ShopInfo ShopInfo
		{
			get;
			set;
		}
	}
}

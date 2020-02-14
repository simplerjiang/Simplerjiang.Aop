using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntMerchantExpandPersonalApplyModel : AopObject
	{
		[XmlElement("base_info")]
		public BaseInfo BaseInfo
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

		[XmlElement("login_id")]
		public string LoginId
		{
			get;
			set;
		}

		[XmlElement("operator_info")]
		public OperatorInfo OperatorInfo
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

		[XmlElement("personal_bank_account_info")]
		public PersonnalBankAccountInfo PersonalBankAccountInfo
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

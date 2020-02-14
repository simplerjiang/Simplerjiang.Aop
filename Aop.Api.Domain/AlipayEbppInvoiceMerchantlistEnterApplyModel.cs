using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceMerchantlistEnterApplyModel : AopObject
	{
		[XmlElement("merchant_base")]
		public MerchantBaseEnterOpenModel MerchantBase
		{
			get;
			set;
		}

		[XmlElement("sub_merchant_common_info")]
		public SubMerchantCommonEnterOpenModel SubMerchantCommonInfo
		{
			get;
			set;
		}

		[XmlArray("sub_merchant_list")]
		[XmlArrayItem("sub_merchant_enter_open_model")]
		public List<SubMerchantEnterOpenModel> SubMerchantList
		{
			get;
			set;
		}
	}
}

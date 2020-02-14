using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsMarketingSellerSignModel : AopObject
	{
		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("prod_code")]
		public string ProdCode
		{
			get;
			set;
		}

		[XmlElement("seller")]
		public InsPerson Seller
		{
			get;
			set;
		}

		[XmlElement("sign_alipay_id")]
		public string SignAlipayId
		{
			get;
			set;
		}
	}
}

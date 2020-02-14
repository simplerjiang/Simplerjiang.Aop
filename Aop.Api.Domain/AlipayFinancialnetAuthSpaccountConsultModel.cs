using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayFinancialnetAuthSpaccountConsultModel : AopObject
	{
		[XmlElement("biz_identity")]
		public string BizIdentity
		{
			get;
			set;
		}

		[XmlElement("sign_product_id")]
		public string SignProductId
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

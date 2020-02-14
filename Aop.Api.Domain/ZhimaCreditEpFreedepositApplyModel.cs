using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaCreditEpFreedepositApplyModel : AopObject
	{
		[XmlElement("merchant_order_no")]
		public string MerchantOrderNo
		{
			get;
			set;
		}

		[XmlElement("merchant_url")]
		public string MerchantUrl
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}
	}
}

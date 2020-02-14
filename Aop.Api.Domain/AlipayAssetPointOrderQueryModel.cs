using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayAssetPointOrderQueryModel : AopObject
	{
		[XmlElement("merchant_order_no")]
		public string MerchantOrderNo
		{
			get;
			set;
		}
	}
}

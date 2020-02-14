using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceLogisticsUserOrderQueryModel : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("ext_param")]
		public string ExtParam
		{
			get;
			set;
		}

		[XmlElement("merchant_code")]
		public string MerchantCode
		{
			get;
			set;
		}

		[XmlElement("target_id")]
		public string TargetId
		{
			get;
			set;
		}

		[XmlElement("target_id_type")]
		public string TargetIdType
		{
			get;
			set;
		}
	}
}

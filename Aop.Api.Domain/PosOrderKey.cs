using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PosOrderKey : AopObject
	{
		[XmlElement("dv_sn")]
		public string DvSn
		{
			get;
			set;
		}

		[XmlElement("merchant_id")]
		public string MerchantId
		{
			get;
			set;
		}

		[XmlElement("order_version")]
		public long OrderVersion
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
	}
}

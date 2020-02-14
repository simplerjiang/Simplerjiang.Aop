using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserUnicomOrderInfoSyncModel : AopObject
	{
		[XmlElement("gmt_order_change")]
		public string GmtOrderChange
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

		[XmlElement("order_operate_type")]
		public string OrderOperateType
		{
			get;
			set;
		}

		[XmlElement("phone_no")]
		public string PhoneNo
		{
			get;
			set;
		}

		[XmlElement("product_name")]
		public string ProductName
		{
			get;
			set;
		}

		[XmlElement("sec_key")]
		public string SecKey
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

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppFacepayBillQueryModel : AopObject
	{
		[XmlElement("bill_no")]
		public string BillNo
		{
			get;
			set;
		}

		[XmlElement("out_order_no")]
		public string OutOrderNo
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

		[XmlElement("user_identity_code")]
		public string UserIdentityCode
		{
			get;
			set;
		}
	}
}

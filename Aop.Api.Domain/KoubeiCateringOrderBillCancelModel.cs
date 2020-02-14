using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringOrderBillCancelModel : AopObject
	{
		[XmlElement("action")]
		public string Action
		{
			get;
			set;
		}

		[XmlElement("cancel_time")]
		public string CancelTime
		{
			get;
			set;
		}

		[XmlElement("pos_order_key")]
		public PosOrderKey PosOrderKey
		{
			get;
			set;
		}
	}
}

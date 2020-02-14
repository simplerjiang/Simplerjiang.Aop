using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringOrderInfoCancelModel : AopObject
	{
		[XmlElement("close_time")]
		public string CloseTime
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

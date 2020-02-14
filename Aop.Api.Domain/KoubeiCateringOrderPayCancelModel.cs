using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringOrderPayCancelModel : AopObject
	{
		[XmlElement("out_pay_no")]
		public string OutPayNo
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

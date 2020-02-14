using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoEntertainmentOrderUploadModel : AopObject
	{
		[XmlElement("entertainment_order_info")]
		public EntertainmentOrderInfo EntertainmentOrderInfo
		{
			get;
			set;
		}
	}
}

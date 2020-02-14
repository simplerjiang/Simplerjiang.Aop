using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOverseasTravelPromotionReceiveModel : AopObject
	{
		[XmlElement("ch_info")]
		public string ChInfo
		{
			get;
			set;
		}

		[XmlElement("promotion_id")]
		public string PromotionId
		{
			get;
			set;
		}

		[XmlElement("unique_id")]
		public string UniqueId
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

		[XmlElement("user_id_type")]
		public string UserIdType
		{
			get;
			set;
		}
	}
}

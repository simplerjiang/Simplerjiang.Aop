using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayAccountExratePricingNotifyModel : AopObject
	{
		[XmlElement("client_id")]
		public string ClientId
		{
			get;
			set;
		}

		[XmlElement("inst")]
		public string Inst
		{
			get;
			set;
		}

		[XmlArray("pricing_list")]
		[XmlArrayItem("pricing_v_o")]
		public List<PricingVO> PricingList
		{
			get;
			set;
		}

		[XmlElement("segment_id")]
		public string SegmentId
		{
			get;
			set;
		}

		[XmlElement("time_zone")]
		public string TimeZone
		{
			get;
			set;
		}
	}
}

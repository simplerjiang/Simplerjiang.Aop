using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsMktCampaignDTO : AopObject
	{
		[XmlElement("campaign_id")]
		public string CampaignId
		{
			get;
			set;
		}

		[XmlElement("circulation")]
		public long Circulation
		{
			get;
			set;
		}

		[XmlElement("coupon_config")]
		public InsMktCouponConfigDTO CouponConfig
		{
			get;
			set;
		}

		[XmlElement("end_time")]
		public string EndTime
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlArray("mkt_objects")]
		[XmlArrayItem("ins_mkt_object_d_t_o")]
		public List<InsMktObjectDTO> MktObjects
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("send_algorithm")]
		public string SendAlgorithm
		{
			get;
			set;
		}

		[XmlElement("send_frqnc_type")]
		public long SendFrqncType
		{
			get;
			set;
		}

		[XmlElement("send_frqnc_value")]
		public long SendFrqncValue
		{
			get;
			set;
		}

		[XmlElement("start_time")]
		public string StartTime
		{
			get;
			set;
		}

		[XmlElement("status")]
		public long Status
		{
			get;
			set;
		}
	}
}

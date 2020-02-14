using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsDataDsbEstimateSyncModel : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlArray("estimate_detail_list")]
		[XmlArrayItem("ins_data_dsb_estimate_result_detail")]
		public List<InsDataDsbEstimateResultDetail> EstimateDetailList
		{
			get;
			set;
		}

		[XmlElement("estimate_no")]
		public string EstimateNo
		{
			get;
			set;
		}

		[XmlElement("frame_no")]
		public string FrameNo
		{
			get;
			set;
		}

		[XmlElement("license_no")]
		public string LicenseNo
		{
			get;
			set;
		}

		[XmlElement("repair_corp_properties")]
		public string RepairCorpProperties
		{
			get;
			set;
		}

		[XmlElement("total_damage_amount")]
		public string TotalDamageAmount
		{
			get;
			set;
		}

		[XmlElement("total_remain_value")]
		public string TotalRemainValue
		{
			get;
			set;
		}
	}
}

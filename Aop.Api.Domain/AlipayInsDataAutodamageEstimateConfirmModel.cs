using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsDataAutodamageEstimateConfirmModel : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("commercial_policy_no")]
		public string CommercialPolicyNo
		{
			get;
			set;
		}

		[XmlElement("compulsory_policy_no")]
		public string CompulsoryPolicyNo
		{
			get;
			set;
		}

		[XmlElement("engine_no")]
		public string EngineNo
		{
			get;
			set;
		}

		[XmlArray("estimate_detail_list")]
		[XmlArrayItem("ins_data_autodamage_estimate_confirm_model")]
		public List<InsDataAutodamageEstimateConfirmModel> EstimateDetailList
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

		[XmlElement("model_brand")]
		public string ModelBrand
		{
			get;
			set;
		}

		[XmlElement("repair_corp_name")]
		public string RepairCorpName
		{
			get;
			set;
		}

		[XmlElement("repair_corp_type")]
		public string RepairCorpType
		{
			get;
			set;
		}

		[XmlElement("report_no")]
		public string ReportNo
		{
			get;
			set;
		}

		[XmlElement("survey_no")]
		public string SurveyNo
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

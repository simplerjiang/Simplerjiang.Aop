using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsDataDsbEstimateApplyModel : AopObject
	{
		[XmlElement("car_properties")]
		public string CarProperties
		{
			get;
			set;
		}

		[XmlElement("case_properties")]
		public string CaseProperties
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

		[XmlElement("estimate_no")]
		public string EstimateNo
		{
			get;
			set;
		}

		[XmlElement("estimate_request_uuid")]
		public string EstimateRequestUuid
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

		[XmlArray("image_list")]
		[XmlArrayItem("alipay_ins_data_dsb_request_image_info")]
		public List<AlipayInsDataDsbRequestImageInfo> ImageList
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

		[XmlElement("repair_corp_properties")]
		public string RepairCorpProperties
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

		[XmlElement("request_timestamp")]
		public string RequestTimestamp
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
	}
}

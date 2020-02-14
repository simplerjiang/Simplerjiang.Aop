using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMedicalcareHosReportnotifyModel : AopObject
	{
		[XmlElement("dept_info")]
		public MedicalHospitalDeptInfo DeptInfo
		{
			get;
			set;
		}

		[XmlElement("doctor_info")]
		public MedicalHospitalDoctorInfo DoctorInfo
		{
			get;
			set;
		}

		[XmlElement("extend_params")]
		public string ExtendParams
		{
			get;
			set;
		}

		[XmlElement("hos_info")]
		public MedicalHospitalInfo HosInfo
		{
			get;
			set;
		}

		[XmlElement("notify_time")]
		public string NotifyTime
		{
			get;
			set;
		}

		[XmlElement("operate")]
		public string Operate
		{
			get;
			set;
		}

		[XmlElement("patient_card_no")]
		public string PatientCardNo
		{
			get;
			set;
		}

		[XmlElement("patient_card_type")]
		public string PatientCardType
		{
			get;
			set;
		}

		[XmlElement("patient_name")]
		public string PatientName
		{
			get;
			set;
		}

		[XmlElement("reg_out_trade_no")]
		public string RegOutTradeNo
		{
			get;
			set;
		}

		[XmlArray("report_list")]
		[XmlArrayItem("medical_hospital_report_list")]
		public List<MedicalHospitalReportList> ReportList
		{
			get;
			set;
		}

		[XmlElement("third_no")]
		public string ThirdNo
		{
			get;
			set;
		}

		[XmlElement("treat_out_trade_no")]
		public string TreatOutTradeNo
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
	}
}

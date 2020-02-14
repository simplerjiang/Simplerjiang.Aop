using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMedicalcareHosRegnotifyModel : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("cancel_desc")]
		public string CancelDesc
		{
			get;
			set;
		}

		[XmlElement("cancel_reason")]
		public string CancelReason
		{
			get;
			set;
		}

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

		[XmlElement("line_no")]
		public long LineNo
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

		[XmlElement("order_link")]
		public string OrderLink
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

		[XmlElement("reg_link")]
		public string RegLink
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

		[XmlElement("treat_date")]
		public string TreatDate
		{
			get;
			set;
		}

		[XmlElement("treat_date_ext")]
		public string TreatDateExt
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

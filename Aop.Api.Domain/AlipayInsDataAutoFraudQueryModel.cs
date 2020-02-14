using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsDataAutoFraudQueryModel : AopObject
	{
		[XmlElement("accident_city")]
		public string AccidentCity
		{
			get;
			set;
		}

		[XmlElement("accident_date")]
		public string AccidentDate
		{
			get;
			set;
		}

		[XmlElement("accident_location")]
		public string AccidentLocation
		{
			get;
			set;
		}

		[XmlElement("case_amount")]
		public string CaseAmount
		{
			get;
			set;
		}

		[XmlElement("estimate_damage_amount")]
		public string EstimateDamageAmount
		{
			get;
			set;
		}

		[XmlElement("informant")]
		public Informant Informant
		{
			get;
			set;
		}

		[XmlElement("injured_count")]
		public long InjuredCount
		{
			get;
			set;
		}

		[XmlArray("injured_list")]
		[XmlArrayItem("injured")]
		public List<Injured> InjuredList
		{
			get;
			set;
		}

		[XmlElement("insure_city")]
		public string InsureCity
		{
			get;
			set;
		}

		[XmlElement("insured")]
		public Insured Insured
		{
			get;
			set;
		}

		[XmlElement("policy_no")]
		public string PolicyNo
		{
			get;
			set;
		}

		[XmlElement("report_date")]
		public string ReportDate
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

		[XmlElement("request_no")]
		public string RequestNo
		{
			get;
			set;
		}

		[XmlElement("scene_type")]
		public string SceneType
		{
			get;
			set;
		}

		[XmlElement("subject_car")]
		public ReportCar SubjectCar
		{
			get;
			set;
		}

		[XmlElement("third_party_car_count")]
		public long ThirdPartyCarCount
		{
			get;
			set;
		}

		[XmlArray("third_party_car_list")]
		[XmlArrayItem("report_car")]
		public List<ReportCar> ThirdPartyCarList
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ReportCar : AopObject
	{
		[XmlElement("assessor")]
		public Person Assessor
		{
			get;
			set;
		}

		[XmlElement("driver")]
		public Person Driver
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

		[XmlElement("garage_address")]
		public string GarageAddress
		{
			get;
			set;
		}

		[XmlElement("garage_name")]
		public string GarageName
		{
			get;
			set;
		}

		[XmlElement("garage_phone_no")]
		public string GaragePhoneNo
		{
			get;
			set;
		}

		[XmlElement("garage_type")]
		public string GarageType
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

		[XmlElement("survey_first_commit_date")]
		public string SurveyFirstCommitDate
		{
			get;
			set;
		}

		[XmlElement("survey_last_commit_date")]
		public string SurveyLastCommitDate
		{
			get;
			set;
		}

		[XmlElement("surveyor")]
		public Person Surveyor
		{
			get;
			set;
		}
	}
}

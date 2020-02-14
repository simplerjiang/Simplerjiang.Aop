using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsAutoAutoinsprodEnquriyApplyModel : AopObject
	{
		[XmlElement("agent")]
		public InsPerson Agent
		{
			get;
			set;
		}

		[XmlElement("agent_user_id")]
		public string AgentUserId
		{
			get;
			set;
		}

		[XmlElement("applicant")]
		public InsPerson Applicant
		{
			get;
			set;
		}

		[XmlElement("car")]
		public Car Car
		{
			get;
			set;
		}

		[XmlElement("car_owner")]
		public InsPerson CarOwner
		{
			get;
			set;
		}

		[XmlElement("city_code")]
		public string CityCode
		{
			get;
			set;
		}

		[XmlElement("insured")]
		public InsPerson Insured
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}
	}
}

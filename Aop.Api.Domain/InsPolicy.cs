using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsPolicy : AopObject
	{
		[XmlElement("addressee")]
		public InsAddressee Addressee
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

		[XmlElement("biz_data")]
		public string BizData
		{
			get;
			set;
		}

		[XmlArray("claims")]
		[XmlArrayItem("ins_claim")]
		public List<InsClaim> Claims
		{
			get;
			set;
		}

		[XmlArray("coverages")]
		[XmlArrayItem("ins_coverage")]
		public List<InsCoverage> Coverages
		{
			get;
			set;
		}

		[XmlElement("effect_end_time")]
		public string EffectEndTime
		{
			get;
			set;
		}

		[XmlElement("effect_start_time")]
		public string EffectStartTime
		{
			get;
			set;
		}

		[XmlArray("ins_objects")]
		[XmlArrayItem("ins_object")]
		public List<InsObject> InsObjects
		{
			get;
			set;
		}

		[XmlArray("insureds")]
		[XmlArrayItem("ins_person")]
		public List<InsPerson> Insureds
		{
			get;
			set;
		}

		[XmlElement("merchant_name")]
		public string MerchantName
		{
			get;
			set;
		}

		[XmlElement("out_policy_no")]
		public string OutPolicyNo
		{
			get;
			set;
		}

		[XmlElement("pay_end_time")]
		public string PayEndTime
		{
			get;
			set;
		}

		[XmlElement("pay_to_time")]
		public string PayToTime
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

		[XmlElement("policy_status")]
		public string PolicyStatus
		{
			get;
			set;
		}

		[XmlElement("premium")]
		public long Premium
		{
			get;
			set;
		}

		[XmlElement("prod_name")]
		public string ProdName
		{
			get;
			set;
		}

		[XmlElement("sum_insured")]
		public long SumInsured
		{
			get;
			set;
		}

		[XmlElement("surrender_fee")]
		public long SurrenderFee
		{
			get;
			set;
		}

		[XmlElement("surrender_time")]
		public string SurrenderTime
		{
			get;
			set;
		}
	}
}

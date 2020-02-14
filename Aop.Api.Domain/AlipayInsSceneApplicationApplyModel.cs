using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsSceneApplicationApplyModel : AopObject
	{
		[XmlElement("activity_id")]
		public string ActivityId
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

		[XmlElement("bill_title")]
		public string BillTitle
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

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("period")]
		public string Period
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

		[XmlElement("prod_code")]
		public string ProdCode
		{
			get;
			set;
		}

		[XmlElement("source")]
		public string Source
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
	}
}

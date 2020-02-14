using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsApplication : AopObject
	{
		[XmlElement("biz_data")]
		public string BizData
		{
			get;
			set;
		}

		[XmlElement("copies")]
		public long Copies
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

		[XmlElement("ins_object")]
		public InsObject InsObject
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

		[XmlElement("sum_insured")]
		public long SumInsured
		{
			get;
			set;
		}
	}
}

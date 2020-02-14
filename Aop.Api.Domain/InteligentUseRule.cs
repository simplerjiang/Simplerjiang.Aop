using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InteligentUseRule : AopObject
	{
		[XmlElement("inteligent_forbidden_time")]
		public InteligentForbiddenTime InteligentForbiddenTime
		{
			get;
			set;
		}

		[XmlArray("inteligent_use_times")]
		[XmlArrayItem("inteligent_use_time")]
		public List<InteligentUseTime> InteligentUseTimes
		{
			get;
			set;
		}

		[XmlElement("limit_rule")]
		public string LimitRule
		{
			get;
			set;
		}

		[XmlElement("min_consume")]
		public string MinConsume
		{
			get;
			set;
		}

		[XmlElement("min_consume_condition")]
		public InteligentDataCondition MinConsumeCondition
		{
			get;
			set;
		}

		[XmlElement("pay_redirect_url")]
		public string PayRedirectUrl
		{
			get;
			set;
		}

		[XmlArray("suit_shops")]
		[XmlArrayItem("string")]
		public List<string> SuitShops
		{
			get;
			set;
		}
	}
}

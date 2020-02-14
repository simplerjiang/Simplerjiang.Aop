using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class UseRule : AopObject
	{
		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("forbidden_time")]
		public ForbbidenTime ForbiddenTime
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

		[XmlArray("use_time")]
		[XmlArrayItem("use_time")]
		public List<UseTime> UseTime
		{
			get;
			set;
		}
	}
}

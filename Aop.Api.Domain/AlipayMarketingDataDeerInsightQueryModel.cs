using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingDataDeerInsightQueryModel : AopObject
	{
		[XmlElement("alias")]
		public string Alias
		{
			get;
			set;
		}

		[XmlElement("app")]
		public string App
		{
			get;
			set;
		}

		[XmlElement("auth")]
		public string Auth
		{
			get;
			set;
		}

		[XmlElement("force")]
		public bool Force
		{
			get;
			set;
		}

		[XmlElement("force_update")]
		public bool ForceUpdate
		{
			get;
			set;
		}

		[XmlElement("group_domain")]
		public string GroupDomain
		{
			get;
			set;
		}

		[XmlElement("insight_domain")]
		public string InsightDomain
		{
			get;
			set;
		}

		[XmlElement("params")]
		public string Params
		{
			get;
			set;
		}

		[XmlElement("system")]
		public string System
		{
			get;
			set;
		}
	}
}

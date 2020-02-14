using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ProductVOOptions : AopObject
	{
		[XmlElement("include_condition_group")]
		public bool IncludeConditionGroup
		{
			get;
			set;
		}

		[XmlElement("include_prod_base")]
		public bool IncludeProdBase
		{
			get;
			set;
		}

		[XmlElement("include_prod_ip")]
		public bool IncludeProdIp
		{
			get;
			set;
		}

		[XmlElement("include_prod_lo")]
		public bool IncludeProdLo
		{
			get;
			set;
		}

		[XmlElement("include_prod_mark")]
		public bool IncludeProdMark
		{
			get;
			set;
		}

		[XmlElement("include_prod_rel")]
		public string IncludeProdRel
		{
			get;
			set;
		}

		[XmlElement("include_prod_ri")]
		public bool IncludeProdRi
		{
			get;
			set;
		}
	}
}

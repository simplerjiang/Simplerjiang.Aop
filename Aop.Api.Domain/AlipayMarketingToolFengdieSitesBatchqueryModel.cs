using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingToolFengdieSitesBatchqueryModel : AopObject
	{
		[XmlElement("operator")]
		public string Operator
		{
			get;
			set;
		}

		[XmlElement("page_number")]
		public string PageNumber
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public string PageSize
		{
			get;
			set;
		}

		[XmlElement("space_id")]
		public string SpaceId
		{
			get;
			set;
		}
	}
}

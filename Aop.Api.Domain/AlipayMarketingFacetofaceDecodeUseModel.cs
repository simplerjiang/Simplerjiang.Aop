using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingFacetofaceDecodeUseModel : AopObject
	{
		[XmlElement("dynamic_id")]
		public string DynamicId
		{
			get;
			set;
		}

		[XmlElement("sence_no")]
		public string SenceNo
		{
			get;
			set;
		}
	}
}

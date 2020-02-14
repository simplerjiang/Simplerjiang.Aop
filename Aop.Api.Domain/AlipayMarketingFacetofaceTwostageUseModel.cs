using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingFacetofaceTwostageUseModel : AopObject
	{
		[XmlElement("biz_sence")]
		public string BizSence
		{
			get;
			set;
		}

		[XmlElement("dynamic_id")]
		public string DynamicId
		{
			get;
			set;
		}

		[XmlElement("ext_data")]
		public string ExtData
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

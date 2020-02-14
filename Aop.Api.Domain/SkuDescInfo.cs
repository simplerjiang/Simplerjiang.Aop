using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SkuDescInfo : AopObject
	{
		[XmlElement("city")]
		public string City
		{
			get;
			set;
		}

		[XmlElement("out_pv_id")]
		public string OutPvId
		{
			get;
			set;
		}

		[XmlElement("out_sku_id")]
		public string OutSkuId
		{
			get;
			set;
		}
	}
}

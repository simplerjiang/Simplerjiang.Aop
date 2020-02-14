using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SkuPropertyValue : AopObject
	{
		[XmlElement("out_pv_id")]
		public string OutPvId
		{
			get;
			set;
		}

		[XmlElement("value")]
		public string Value
		{
			get;
			set;
		}
	}
}

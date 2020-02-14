using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOverseasTaxOrderQueryModel : AopObject
	{
		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceTitleDynamicGetModel : AopObject
	{
		[XmlElement("bar_code")]
		public string BarCode
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradeWapMergePayModel : AopObject
	{
		[XmlElement("pre_order_no")]
		public string PreOrderNo
		{
			get;
			set;
		}
	}
}

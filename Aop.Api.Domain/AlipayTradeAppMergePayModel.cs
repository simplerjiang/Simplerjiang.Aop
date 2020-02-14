using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradeAppMergePayModel : AopObject
	{
		[XmlElement("pre_order_no")]
		public string PreOrderNo
		{
			get;
			set;
		}
	}
}

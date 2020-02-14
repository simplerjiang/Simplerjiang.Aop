using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDaoweiOrderQueryModel : AopObject
	{
		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}
	}
}

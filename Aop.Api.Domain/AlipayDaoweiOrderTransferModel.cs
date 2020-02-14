using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDaoweiOrderTransferModel : AopObject
	{
		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("order_action")]
		public string OrderAction
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}
	}
}

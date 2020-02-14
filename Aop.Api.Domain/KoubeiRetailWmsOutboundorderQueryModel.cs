using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsOutboundorderQueryModel : AopObject
	{
		[XmlElement("need_detail")]
		public bool NeedDetail
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("outbound_order_id")]
		public string OutboundOrderId
		{
			get;
			set;
		}
	}
}

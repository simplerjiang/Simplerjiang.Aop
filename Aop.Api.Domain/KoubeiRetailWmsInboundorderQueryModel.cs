using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsInboundorderQueryModel : AopObject
	{
		[XmlElement("inbound_order_id")]
		public string InboundOrderId
		{
			get;
			set;
		}

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
	}
}

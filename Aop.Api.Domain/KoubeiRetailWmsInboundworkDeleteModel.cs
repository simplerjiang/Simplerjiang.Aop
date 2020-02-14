using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsInboundworkDeleteModel : AopObject
	{
		[XmlElement("inbound_work_id")]
		public string InboundWorkId
		{
			get;
			set;
		}

		[XmlElement("operate_context")]
		public OperateContext OperateContext
		{
			get;
			set;
		}
	}
}

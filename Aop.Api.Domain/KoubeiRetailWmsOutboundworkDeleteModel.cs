using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsOutboundworkDeleteModel : AopObject
	{
		[XmlElement("operate_context")]
		public OperateContext OperateContext
		{
			get;
			set;
		}

		[XmlElement("outbound_work_id")]
		public string OutboundWorkId
		{
			get;
			set;
		}
	}
}

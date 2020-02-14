using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoCplifeRepairStatusUpdateModel : AopObject
	{
		[XmlElement("biz_details")]
		public string BizDetails
		{
			get;
			set;
		}

		[XmlElement("biz_state")]
		public string BizState
		{
			get;
			set;
		}

		[XmlElement("req_id")]
		public string ReqId
		{
			get;
			set;
		}
	}
}

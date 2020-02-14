using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarMaintainAftersaleSyncModel : AopObject
	{
		[XmlElement("aftersale_no")]
		public string AftersaleNo
		{
			get;
			set;
		}

		[XmlElement("refuse_reason")]
		public string RefuseReason
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}

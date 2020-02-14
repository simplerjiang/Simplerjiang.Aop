using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAppNotifyVerifyModel : AopObject
	{
		[XmlElement("notify_id")]
		public string NotifyId
		{
			get;
			set;
		}
	}
}

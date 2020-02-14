using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicThirdCustomerServiceModel : AopObject
	{
		[XmlElement("channel_uid")]
		public string ChannelUid
		{
			get;
			set;
		}
	}
}

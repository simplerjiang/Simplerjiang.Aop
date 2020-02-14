using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceTransportOfflinepayRecordVerifyModel : AopObject
	{
		[XmlElement("record")]
		public string Record
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingToolFengdieActivityQueryModel : AopObject
	{
		[XmlElement("activity_id")]
		public long ActivityId
		{
			get;
			set;
		}
	}
}

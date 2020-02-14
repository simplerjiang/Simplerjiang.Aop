using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingToolFengdieSpaceCreateModel : AopObject
	{
		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingUserulePidQueryModel : AopObject
	{
		[XmlElement("pid")]
		public string Pid
		{
			get;
			set;
		}
	}
}

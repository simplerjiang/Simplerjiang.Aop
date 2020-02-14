using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserCustIdentifyActivity : AopObject
	{
		[XmlElement("activity_info")]
		public string ActivityInfo
		{
			get;
			set;
		}

		[XmlElement("activity_name")]
		public string ActivityName
		{
			get;
			set;
		}
	}
}

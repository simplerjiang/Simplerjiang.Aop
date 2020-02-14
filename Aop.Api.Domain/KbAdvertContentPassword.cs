using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertContentPassword : AopObject
	{
		[XmlElement("password")]
		public string Password
		{
			get;
			set;
		}

		[XmlElement("share_page_url")]
		public string SharePageUrl
		{
			get;
			set;
		}
	}
}

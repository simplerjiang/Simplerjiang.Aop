using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseIdpsourceSyncModel : AopObject
	{
		[XmlElement("data")]
		public string Data
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}
	}
}

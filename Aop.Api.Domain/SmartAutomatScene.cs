using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SmartAutomatScene : AopObject
	{
		[XmlElement("level_1")]
		public string Level1
		{
			get;
			set;
		}

		[XmlElement("level_2")]
		public string Level2
		{
			get;
			set;
		}
	}
}

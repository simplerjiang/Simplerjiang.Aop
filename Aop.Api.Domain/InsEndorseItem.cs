using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsEndorseItem : AopObject
	{
		[XmlElement("new_value")]
		public string NewValue
		{
			get;
			set;
		}

		[XmlElement("old_value")]
		public string OldValue
		{
			get;
			set;
		}

		[XmlElement("type")]
		public long Type
		{
			get;
			set;
		}
	}
}

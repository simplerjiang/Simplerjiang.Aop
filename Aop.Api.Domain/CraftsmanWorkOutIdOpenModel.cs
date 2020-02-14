using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CraftsmanWorkOutIdOpenModel : AopObject
	{
		[XmlElement("out_work_id")]
		public string OutWorkId
		{
			get;
			set;
		}

		[XmlElement("work_id")]
		public string WorkId
		{
			get;
			set;
		}
	}
}

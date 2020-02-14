using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieActivityCreateModel : AopObject
	{
		[XmlElement("activity_id")]
		public long ActivityId
		{
			get;
			set;
		}
	}
}

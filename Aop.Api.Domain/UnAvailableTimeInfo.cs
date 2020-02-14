using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class UnAvailableTimeInfo : AopObject
	{
		[XmlElement("from_date")]
		public string FromDate
		{
			get;
			set;
		}

		[XmlElement("to_date")]
		public string ToDate
		{
			get;
			set;
		}
	}
}

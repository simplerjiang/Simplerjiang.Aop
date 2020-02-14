using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlisisReportColumn : AopObject
	{
		[XmlElement("alias")]
		public string Alias
		{
			get;
			set;
		}

		[XmlElement("data")]
		public string Data
		{
			get;
			set;
		}
	}
}

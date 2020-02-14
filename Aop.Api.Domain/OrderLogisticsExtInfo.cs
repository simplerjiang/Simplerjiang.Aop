using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OrderLogisticsExtInfo : AopObject
	{
		[XmlElement("gmt_end")]
		public string GmtEnd
		{
			get;
			set;
		}

		[XmlElement("gmt_start")]
		public string GmtStart
		{
			get;
			set;
		}
	}
}

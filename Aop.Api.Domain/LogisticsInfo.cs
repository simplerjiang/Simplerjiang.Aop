using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class LogisticsInfo : AopObject
	{
		[XmlElement("logistics_code")]
		public string LogisticsCode
		{
			get;
			set;
		}

		[XmlElement("logistics_name")]
		public string LogisticsName
		{
			get;
			set;
		}

		[XmlElement("logistics_no")]
		public string LogisticsNo
		{
			get;
			set;
		}
	}
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DataSecCheckResult : AopObject
	{
		[XmlElement("check_date")]
		public string CheckDate
		{
			get;
			set;
		}

		[XmlElement("data_id")]
		public string DataId
		{
			get;
			set;
		}

		[XmlElement("data_status")]
		public string DataStatus
		{
			get;
			set;
		}
	}
}

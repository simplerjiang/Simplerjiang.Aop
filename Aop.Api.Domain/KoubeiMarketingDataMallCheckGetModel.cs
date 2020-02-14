using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataMallCheckGetModel : AopObject
	{
		[XmlArray("check_contents")]
		[XmlArrayItem("data_sec_check_content")]
		public List<DataSecCheckContent> CheckContents
		{
			get;
			set;
		}

		[XmlElement("data_source")]
		public string DataSource
		{
			get;
			set;
		}
	}
}

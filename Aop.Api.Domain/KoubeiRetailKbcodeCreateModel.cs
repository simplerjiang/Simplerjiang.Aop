using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailKbcodeCreateModel : AopObject
	{
		[XmlArray("code_info_list")]
		[XmlArrayItem("retail_kbcode_create_vo")]
		public List<RetailKbcodeCreateVo> CodeInfoList
		{
			get;
			set;
		}

		[XmlElement("code_template")]
		public string CodeTemplate
		{
			get;
			set;
		}

		[XmlElement("code_type")]
		public string CodeType
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}
	}
}

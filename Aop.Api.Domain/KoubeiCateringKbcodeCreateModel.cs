using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringKbcodeCreateModel : AopObject
	{
		[XmlArray("bind_info_list")]
		[XmlArrayItem("kb_code_bind_info_v_o")]
		public List<KbCodeBindInfoVO> BindInfoList
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

		[XmlElement("stuff_template")]
		public string StuffTemplate
		{
			get;
			set;
		}

		[XmlElement("stuff_type")]
		public string StuffType
		{
			get;
			set;
		}
	}
}

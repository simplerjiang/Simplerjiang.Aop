using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayIserviceItaskProcessDetailModifyResponse : AopResponse
	{
		[XmlElement("alipay_process_id")]
		public string AlipayProcessId
		{
			get;
			set;
		}

		[XmlElement("alipay_process_status")]
		public string AlipayProcessStatus
		{
			get;
			set;
		}

		[XmlArray("extend_field_infos")]
		[XmlArrayItem("extend_field_info")]
		public List<ExtendFieldInfo> ExtendFieldInfos
		{
			get;
			set;
		}
	}
}

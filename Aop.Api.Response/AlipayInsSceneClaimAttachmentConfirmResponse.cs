using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsSceneClaimAttachmentConfirmResponse : AopResponse
	{
		[XmlArray("lost_files")]
		[XmlArrayItem("string")]
		public List<string> LostFiles
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
